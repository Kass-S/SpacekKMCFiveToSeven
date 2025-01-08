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
    public class OddEvenController : ControllerBase
    {
        private readonly OddEvenServices _oddEvenSercices;
        public OddEvenController(OddEvenServices oddEvenServices)
        {
            _oddEvenSercices =  oddEvenServices;
        }

        [HttpGet]
        [Route("OddEven/{oddEvenNum}")]
        public string OddEven(string oddEvenNum)
        {
            return _oddEvenSercices.OddEven(oddEvenNum);
        }
    }
}