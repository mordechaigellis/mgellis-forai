using System.Data;
using System.Data.SqlClient;

namespace RecordKeeperTest
{
    public class PresidentTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=RecordKeeperDB;Trusted_Connection=true");
            
        }


        [Test]
        [TestCase("Sam", "Test1", "2035-1-1", 2075)]
        [TestCase("Sam", "Test2", "1800-1-1", 1836)]
        public void InsertNewPresident(string firstname, string lastname, DateTime dateborn, int termstart) {
            DataTable dt = SQLUtility.GetDataTable("select * from president where presidentid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int partyid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 partyid from party");
            Assume.That(partyid > 0, "Can't run test no parties in the db");
            int maxnum = SQLUtility.GetFirstColumnFirstRowValue("select max(num) from president");
            
            maxnum = maxnum + 1;

            TestContext.WriteLine("insert president with num = " + maxnum);

            r["partyid"] = partyid;
            r["Num"] = maxnum;
            r["FirstName"] = firstname;
            r["LastName"] = lastname;
            r["DateBorn"] = dateborn;
            r["TermStart"] = termstart;
            President.Save(dt);

            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from president where num = " + maxnum);

            Assert.IsTrue(newid > 0, "president with num = " + maxnum + " is not found in db");
            TestContext.WriteLine("President with " + maxnum + " is found in db with pk value = " + newid);
        }

        [Test]
        public void ChangeExistingPresidentTermStart() {
            int presidentid = GetExistingPresidentId();
            Assume.That(presidentid > 0, "No presidents in DB, can't run test");
            int termstart = SQLUtility.GetFirstColumnFirstRowValue("select termstart from president where presidentid = " + presidentid);
            TestContext.WriteLine("termstart for presidentid " + presidentid + " is " + termstart);
            termstart = termstart + 1;
            TestContext.WriteLine("change termstart to " + termstart);

            DataTable dt = President.Load(presidentid);
            dt.Rows[0]["termstart"] = termstart;
            President.Save(dt);
            
            int newtermstart = SQLUtility.GetFirstColumnFirstRowValue("select termstart from president where presidentid = " + presidentid);
            Assert.IsTrue(newtermstart == termstart,"termstart for president (" + presidentid + ") = " + newtermstart);
            TestContext.WriteLine("termstart for president(" + presidentid + ") = " + newtermstart);
        }

        [Test]
        public void DeletePresident() {
            DataTable dt = SQLUtility.GetDataTable("select top 1 p.presidentid, Num, LastName from president p left join executiveorder e on e.presidentid = p.presidentid where e.executiveorderid is null");
            int presidentid = 0;
            string prezdesc = "";
            if (dt.Rows.Count > 0)
            {
                presidentid = (int)dt.Rows[0]["presidentid"];
                prezdesc = dt.Rows[0]["Num"] + " " + dt.Rows[0]["LastName"];
            }
            Assume.That(presidentid > 0, "No presidents without executive order in DB, can't run test");
            TestContext.WriteLine("existing president without executive order, with id = " + presidentid + " " + prezdesc);
            TestContext.WriteLine("ensure that app can delete " + presidentid);
            President.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from president where presidentid = " + presidentid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0,"record with presidentid " + presidentid + " exists in db");
            TestContext.WriteLine("Record with presidentid " + presidentid + " does not exist in DB");
        }

        [Test]
        public void LoadPresident() {
            int presidentid = GetExistingPresidentId();
            Assume.That(presidentid > 0, "No presidents in DB, can't run test");
            TestContext.WriteLine("existing president with id = " + presidentid);
            TestContext.WriteLine("Ensure that app loads president " + presidentid);
            DataTable dt = President.Load(presidentid);
            int loadedid = (int)dt.Rows[0]["presidentid"];
            Assert.IsTrue(loadedid == presidentid, (int)dt.Rows[0]["presidentid"] + " <> " + presidentid);
            TestContext.WriteLine("Loaded president (" + loadedid + ")");
        }

        [Test]
        public void GetListOfParties()
        {
            int partycount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from party");
            Assume.That(partycount > 0, "No parties in DB, can't test");
            TestContext.WriteLine("Num of parties in DB = " + partycount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + partycount);
            
            DataTable dt = President.GetPartyList();
            
            Assert.IsTrue(dt.Rows.Count == partycount,"num rows returned by app (" + dt.Rows.Count + ") <> " + partycount);
            
            TestContext.WriteLine("Number of rows in Parties return by app = " + dt.Rows.Count);
        }

        private int GetExistingPresidentId() {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 presidentid from president");
        }
    }
}