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
    public class MadLibController : ControllerBase
    {
        
private readonly MadLibServices _madLibServices;
        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }
        
        [HttpGet]
        [Route("MadLib/{noun}/{animal}/{name}/{diffName}/{emotion}/{action1}/{dreamJob}/{structure}")]
        public string MadLib(string noun, string animal, string name, string diffName, string emotion, string action1, string dreamJob, string structure)
        {
            return _madLibServices.MadLib(noun, animal, name, diffName, emotion, action1, dreamJob, structure);
        }

    }
}