using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecordKeeperSystem;

namespace RecordKeeperAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartyController : ControllerBase
    {
        [HttpGet]
        public List<bizParty> Get() {
            return new bizParty().GetList();
        }

        [HttpGet("{id:int:min(0)}")]
        public bizParty Get(int id) {
            bizParty p = new bizParty();
            p.Load(id);
            return p;
        }
    }
}
