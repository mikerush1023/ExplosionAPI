using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MumblingController : ControllerBase
    {
        [HttpGet("{mumbler}")]
        public string Mumbler(string mumbling)
        {
            var answer = "";
            var count = 0;
            foreach (char character in mumbling.ToUpper())
            {
                if (count != 0) answer += "-";
                answer += character;
                answer += new String(char.ToLower(character), count);
                ++count;
            }
            return answer;
        }
    }
}