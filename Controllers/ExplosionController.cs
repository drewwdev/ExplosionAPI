using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet]
        public string Exploder(string str)
        {
            var newString = "";
            foreach (var number in str)
            {
                for (var index = 0; index < number - '0'; index++)
                {
                    newString += number;
                }
            }
            return newString;
        }
    }
}