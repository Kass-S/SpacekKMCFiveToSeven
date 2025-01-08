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
    public class StringReverseController : ControllerBase
    {
        private readonly StringReverseServices _stringReverseServices;
        public StringReverseController(StringReverseServices stringReverseServices)
        {
            _stringReverseServices = stringReverseServices;
        }

        [HttpGet]
        [Route("Reverse/{reverseStr}")]
        public string ReverseString(string reverseStr)
        {
            return _stringReverseServices.ReverseString(reverseStr);
        }
    }
}