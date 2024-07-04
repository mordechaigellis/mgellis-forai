﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecordKeeperSystem;

namespace RecordKeeperAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresidentMedalController : ControllerBase
    {
        [HttpGet]
        public List<bizPresidentMedal> Get()
        {
            return new bizPresidentMedal().GetList();
        }

        [HttpGet("{id:int:min(0)}")]
        public bizPresidentMedal Get(int id)
        {
            bizPresidentMedal p = new bizPresidentMedal();
            p.Load(id);
            return p;
        }


        [HttpPost]
        [AuthPermission(1)]
        public IActionResult Post(bizPresidentMedal PresidentMedal)
        {
            try
            {
                PresidentMedal.Save();
                return Ok(PresidentMedal);
            }
            catch (Exception ex)
            {
                PresidentMedal.ErrorMessage = ex.Message;
                return BadRequest(PresidentMedal);
            }

        }

        [HttpDelete]
        [AuthPermission(1)]
        public IActionResult Delete(int id)
        {
            bizPresidentMedal p = new();
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
        
        [HttpGet("medals")]
        public List<bizMedal> GetMedals()
        {
            return new bizMedal().GetList(true);
        }


    }
}
