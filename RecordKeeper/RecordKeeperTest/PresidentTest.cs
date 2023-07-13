using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RecordKeeperTest
{
    public class PresidentTest
    {
        string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string testconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;

        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(connstring, true);
            
        }

        private DataTable GetDataTable(string sql) {
            DataTable dt = new();
            DBManager.SetConnectionString(testconnstring, false);
            dt = SQLUtility.GetDataTable(sql);
            DBManager.SetConnectionString(connstring, false);
            return dt;
        }

        private int GetFirstColumnFirstRowValue(string sql) {
            int n = 0;
            DBManager.SetConnectionString(testconnstring, false);
            n = SQLUtility.GetFirstColumnFirstRowValue(sql);
            DBManager.SetConnectionString(connstring, false);
            return n;
        }

        private void ExecuteSQL(string sql) {
            DBManager.SetConnectionString(testconnstring, false);
            SQLUtility.ExecuteSQL(sql);
            DBManager.SetConnectionString(connstring, false);
        }

        [Test]
        [TestCase("Sam", "Test1", "2035-1-1", 2075, 2079)]
        [TestCase("Sam", "Test2", "1800-1-1", 1836, 1840)]
        public void InsertNewPresident(string firstname, string lastname, DateTime dateborn, int termstart, int termend) {
            int partyid = GetFirstColumnFirstRowValue("select top 1 partyid from party");
            Assume.That(partyid > 0, "Can't run test no parties in the db");
            int maxnum = GetFirstColumnFirstRowValue("select max(num) from president");
            
            maxnum = maxnum + 1;

            TestContext.WriteLine("insert president with num = " + maxnum);
            bizPresident prez = new();
            prez.PartyId = partyid;
            prez.Num = 0;
            prez.FirstName = firstname;
            prez.LastName = lastname;
            prez.DateBorn = dateborn;
            //prez.DateDied = dateborn.AddYears(80);
            prez.TermStart = termstart;
            prez.TermEnd = termend;
            
            prez.Save();

            int newnum = GetFirstColumnFirstRowValue("select * from president where num = " + maxnum);
            int pkid = prez.PresidentId;
          
            Assert.IsTrue(newnum > 0, "president with num = " + maxnum + " is not found in db");
            Assert.IsTrue(pkid > 0, "primary key not updated in datatable");
            TestContext.WriteLine("President with " + maxnum + " is found in db with pk value = " + newnum);
            TestContext.WriteLine("new primary key = " + pkid);
        }

        [Test]
        public void ChangeExistingPresidentTermStart() {
            int presidentid = GetExistingPresidentId();
            Assume.That(presidentid > 0, "No presidents in DB, can't run test");
            int termstart = GetFirstColumnFirstRowValue("select termstart from president where presidentid = " + presidentid);
            TestContext.WriteLine("termstart for presidentid " + presidentid + " is " + termstart);
            termstart = termstart - 1;
            TestContext.WriteLine("change termstart to " + termstart);

            DataTable dt = President.Load(presidentid);
            dt.Rows[0]["termstart"] = termstart;
            President.Save(dt);
            
            int newtermstart = GetFirstColumnFirstRowValue("select termstart from president where presidentid = " + presidentid);
            Assert.IsTrue(newtermstart == termstart,"termstart for president (" + presidentid + ") = " + newtermstart);
            TestContext.WriteLine("termstart for president(" + presidentid + ") = " + newtermstart);
        }

        [Test]
        public void ChangeExistingPresidentToInvalidTermStart()
        {
            int presidentid = GetExistingPresidentId();
            int termstart = 0;
            Assume.That(presidentid > 0, "No presidents in DB, can't run test");
            int termend = GetFirstColumnFirstRowValue("select termend from president where presidentid = " + presidentid);

            TestContext.WriteLine("termend for presidentid " + presidentid + " is " + termend);
            termstart = termstart + 1;
            TestContext.WriteLine("change termstart to " + termstart);

            DataTable dt = President.Load(presidentid);
            dt.Rows[0]["termstart"] = termstart;
            Exception ex = Assert.Throws<Exception>(()=> President.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeExistingPresidentToInvalidNum()
        {
            int presidentid = GetExistingPresidentId();
            Assume.That(presidentid > 0, "No presidents in DB, can't run test");
            int num = GetFirstColumnFirstRowValue("select top 1 num from president where presidentid <> " + presidentid);
            int currentnum = GetFirstColumnFirstRowValue("select top 1 num from president where presidentid = " + presidentid);
            Assume.That(num > 0, "Cannot run test becuase there is no other president record in the table");
            TestContext.WriteLine("Change presidentid " + presidentid + " num from " + currentnum +  " to " + num + " which belongs to a different president");
            DataTable dt = President.Load(presidentid);
            dt.Rows[0]["num"] = num;
            Exception ex = Assert.Throws<Exception>(() => President.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        private DataTable GetPrezForDelete() {
            string sql = @"
select top 1 p.PresidentId, p.Num, p.LastName
from President p
left join ExecutiveOrder e
on e.PresidentId = p.PresidentId
left join PresidentMedal pm
on pm.PresidentId = p.PresidentId
where e.ExecutiveOrderId is null
and pm.PresidentMedalId is null
order by p.PresidentId
";
            DataTable dt = GetDataTable(sql);
            return dt;
        }

        [Test]
        public void DeletePresident() {
            
            DataTable dt = GetPrezForDelete();
            int presidentid = 0;
            string prezdesc = "";
            if (dt.Rows.Count > 0)
            {
                presidentid = (int)dt.Rows[0]["presidentid"];
                prezdesc = dt.Rows[0]["Num"] + " " + dt.Rows[0]["LastName"];
            }
            Assume.That(presidentid > 0, "No presidents without executive order in DB, can't run test");
            TestContext.WriteLine("existing president without executive order and medal, with id = " + presidentid + " " + prezdesc);
            TestContext.WriteLine("ensure that app can delete " + presidentid);
            bizPresident prez = new();
            prez.Load(presidentid);
            prez.Delete();
            DataTable dtafterdelete = GetDataTable("select * from president where presidentid = " + presidentid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0,"record with presidentid " + presidentid + " exists in db");
            TestContext.WriteLine("Record with presidentid " + presidentid + " does not exist in DB");
        }

        [Test]
        public void DeletePresidentById()
        {

            DataTable dt = GetPrezForDelete();
            int presidentid = 0;
            string prezdesc = "";
            if (dt.Rows.Count > 0)
            {
                presidentid = (int)dt.Rows[0]["presidentid"];
                prezdesc = dt.Rows[0]["Num"] + " " + dt.Rows[0]["LastName"];
            }
            Assume.That(presidentid > 0, "No presidents without executive order in DB, can't run test");
            TestContext.WriteLine("existing president without executive order and medal, with id = " + presidentid + " " + prezdesc);
            TestContext.WriteLine("ensure that app can delete " + presidentid);
            bizPresident prez = new();
            prez.Delete(presidentid);
            DataTable dtafterdelete = GetDataTable("select * from president where presidentid = " + presidentid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with presidentid " + presidentid + " exists in db");
            TestContext.WriteLine("Record with presidentid " + presidentid + " does not exist in DB");
        }
        [Test]
        public void DeletePresidentByDataTable()
        {

            DataTable dt = GetPrezForDelete();
            int presidentid = 0;
            string prezdesc = "";
            if (dt.Rows.Count > 0)
            {
                presidentid = (int)dt.Rows[0]["presidentid"];
                prezdesc = dt.Rows[0]["Num"] + " " + dt.Rows[0]["LastName"];
            }
            Assume.That(presidentid > 0, "No presidents without executive order in DB, can't run test");
            TestContext.WriteLine("existing president without executive order and medal, with id = " + presidentid + " " + prezdesc);
            TestContext.WriteLine("ensure that app can delete " + presidentid);
            bizPresident prez = new();
            prez.Delete(dt);
            DataTable dtafterdelete = GetDataTable("select * from president where presidentid = " + presidentid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with presidentid " + presidentid + " exists in db");
            TestContext.WriteLine("Record with presidentid " + presidentid + " does not exist in DB");
        }

        [Test]
        public void DeletePresidentWithUpheldExecutiveOrder()
        {
            string sql = @"
select top 1 p.presidentid, Num, LastName 
from president p 
join executiveorder e 
on e.presidentid = p.presidentid
where e.UpheldByCourt = 1
";
            DataTable dt = GetDataTable(sql);
            int presidentid = 0;
            string prezdesc = "";
            if (dt.Rows.Count > 0)
            {
                presidentid = (int)dt.Rows[0]["presidentid"];
                prezdesc = dt.Rows[0]["Num"] + " " + dt.Rows[0]["LastName"];
            }
            Assume.That(presidentid > 0, "No presidents with upheld executive orders in DB, can't run test");
            TestContext.WriteLine("existing president with upheld executive order, with id = " + presidentid + " " + prezdesc);
            TestContext.WriteLine("ensure that app cannot delete " + presidentid);
            
            Exception ex = Assert.Throws<Exception>(()=> President.Delete(dt));
            
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void LoadPresident() {
            int presidentid = GetExistingPresidentId();
            Assume.That(presidentid > 0, "No presidents in DB, can't run test");
            TestContext.WriteLine("existing president with id = " + presidentid);
            TestContext.WriteLine("Ensure that app loads president " + presidentid);
            bizPresident prez = new();
            prez.Load(presidentid);
            int loadedid = prez.PresidentId;
            string lastname = prez.LastName;
            Assert.IsTrue(loadedid == presidentid && lastname != "", loadedid + " <> " + presidentid + " LastName = " + lastname);
            TestContext.WriteLine("Loaded president (" + loadedid + ") LastName = " + lastname);
        }

        [Test]
        public void SearchPresidents() {
            string criteria = "a";
            int num = GetFirstColumnFirstRowValue("select total = count(*) from president where lastname like '%" + criteria + "%'");
            Assume.That(num > 0, "There no presidents that match the search for " + num);
            TestContext.WriteLine(num + " presidents that match " + criteria);
            TestContext.WriteLine("Ensure that president search returns " + num + " rows");

            DataTable dt = President.SearchPresidents(0,criteria,0,0);
            int results = dt.Rows.Count;

            Assert.IsTrue(results == num, "Results of president search does not match number of presidents, " + results + " <> " + num);
            TestContext.WriteLine ("Number of rows returned by president search is " + results);
        }

        [Test]
        public void GetListOfParties()
        {
            int partycount = GetFirstColumnFirstRowValue("select total = count(*) from party");
            Assume.That(partycount > 0, "No parties in DB, can't test");
            TestContext.WriteLine("Num of parties in DB = " + partycount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + partycount);
            
            DataTable dt = President.GetPartyList();
            
            Assert.IsTrue(dt.Rows.Count == partycount,"num rows returned by app (" + dt.Rows.Count + ") <> " + partycount);
            
            TestContext.WriteLine("Number of rows in Parties return by app = " + dt.Rows.Count);
        }

        [Test]
        public void SaveMultipleRows() {
            string sql = "delete season where seasonname in ('TestSeason1','TestSeason2')";
            ExecuteSQL(sql);
            sql = "update season set seasonname = 'OriginalSeason1' where seasonname = 'TestChange1'";
            ExecuteSQL(sql);

            DataTable dt = DataMaintenance.GetDataList("Season");
            var dr = dt.Rows.Add();
            dr["SeasonName"] = "TestSeason1";
            dr = dt.Rows.Add();
            dr["SeasonName"] = "TestSeason2";
            dt.Rows[0]["SeasonName"] = "TestChange1";
            SQLUtility.SaveDataTable(dt,"SeasonUpdate");
            sql = "select * from season where seasonname in ('TestSeason1','TestSeason2', 'TestChange1')";
            DataTable dtcheck = GetDataTable(sql);
            Assert.IsTrue(dtcheck.Rows.Count == 3, $"num rows of dtcheck is {dtcheck.Rows.Count} not 3 rows");
            TestContext.WriteLine($"num rows of dtcheck should be 3 and it is {dtcheck.Rows.Count}");
        }

        private int GetExistingPresidentId() {
            return GetFirstColumnFirstRowValue("select top 1 presidentid from president where TermEnd is null");
        }
    }
}