using calc.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace calc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class calcController : ControllerBase
    {
        Calc oCalc = new Calc();

        [HttpGet("add/{paramOne}/{paramTwo}")]
        public float Get(float paramOne, float paramTwo)
        {
            return oCalc.Add(paramOne, paramTwo);
        }

        [HttpGet("sub/{paramOne}/{paramTwo}")]
        public float GetSub(float paramOne, float paramTwo)
        {
            return oCalc.Sub(paramOne, paramTwo);
        }

        [HttpGet("mul/{paramOne}/{paramTwo}")]
        public float GetMul(float paramOne, float paramTwo)
        {
            return oCalc.Mul(paramOne, paramTwo);
        }

        [HttpGet("div/{paramOne}/{paramTwo}")]
        public float GetDiv(float paramOne, float paramTwo)
        {
            return oCalc.Div(paramOne, paramTwo);
        }
    }
}
