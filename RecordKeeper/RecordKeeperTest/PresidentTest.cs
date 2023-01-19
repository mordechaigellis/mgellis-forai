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
        public void GetListOfParties()
        {
            DataTable dt = President.GetPartyList();
            Assert.IsTrue(dt.Rows.Count > 0);
            TestContext.WriteLine("Number of rows in Parties = " + dt.Rows.Count);
        }
    }
}