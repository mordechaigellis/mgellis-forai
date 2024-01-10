using RecordKeeperSystem;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecordKeeperAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresidentController : ControllerBase
    {
        [HttpGet]
        public List<bizPresident> Get() {
            return new bizPresident().GetList();
        }
    }
}
