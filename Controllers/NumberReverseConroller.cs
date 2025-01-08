using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpacekKMCFiveToSeven.Services;

namespace SpacekKMCFiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberReverseConroller : ControllerBase
    {
        private readonly NumberReverseService _numberReverseSercices;
        public NumberReverseConroller(NumberReverseService numberReverseServices)
        {
            _numberReverseSercices =  numberReverseServices;
        }

        [HttpGet]
        [Route("NumberReverse/{numReverseNum}")]
        public string ReverseNumber(string numReverseNum)
        {
            return _numberReverseSercices.ReverseNumber(numReverseNum);
        }
    }
}