using CPUFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecordKeeperAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(bizUser userobj) {
            try {
                userobj.Login();
                return Ok(userobj);
            }
            catch( Exception ex){
                userobj.ErrorMessage = ex.Message;
                return BadRequest(userobj);
            }
        }


    }
}
