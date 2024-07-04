using Microsoft.AspNetCore.Mvc;
using RecordKeeperSystem;

namespace RecordKeeperAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExecutiveOrderController : ControllerBase
    {
        [HttpPost]
        [AuthPermission(1)]
        public IActionResult Post(bizExecutiveOrder ExecutiveOrder)
        {
            try
            {
                ExecutiveOrder.Save();
                return Ok(ExecutiveOrder);
            }
            catch (Exception ex)
            {
                ExecutiveOrder.ErrorMessage = ex.Message;
                return BadRequest(ExecutiveOrder);
            }

        }

        [HttpDelete]
        [AuthPermission(1)]
        public IActionResult Delete(int id)
        {
            bizExecutiveOrder p = new();
            try
            {
                p.Delete(id);
                return Ok(p);
            }
            catch (Exception ex)
            {
                p.ErrorMessage = ex.Message;
                return BadRequest(p);
            }

        }

    }
}
