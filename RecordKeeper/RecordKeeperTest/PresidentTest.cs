using System.Data;

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
            int presidentid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 presidentid from president");
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
    }
}