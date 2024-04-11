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

        [HttpPost]
        public IActionResult Post(bizParty party) {
            try {
                party.Save();
                return Ok();
            }
            catch (Exception ex) {
                return BadRequest(new { ex.Message });
            }
            
        }

        [HttpDelete]
        public IActionResult Delete(int id) {
            try {
                bizParty p = new();
                p.Delete(id);
                return Ok();
            }
            catch (Exception ex) {
                return BadRequest(new {ex.Message});
            }
            
        }
    }
}
