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
    public class MumblingController : ControllerBase
    {
        [HttpGet]
        public string Mumbler(string str)
        {
            str = str.ToLower();
            var newString = "";
            for (var index = 0; index < str.Length; index++)
            {
                for (var letterIndex = 0; letterIndex <= index; letterIndex++)
                {
                    if (letterIndex == 0)
                    {
                        newString += Char.ToUpper(str[index]);
                    }
                    else
                    {
                        newString += str[index];
                    }
                }
                newString += "-";
            }
            var substring = newString.Substring(0, newString.Length - 1);
            return substring;
        }
    }
}