using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlayCricket.DataReader;
using PlayCricket.Facade;

namespace cricket_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetPlayerTypes()
        {
            PlayCricketFacade pcFacade = new PlayCricketFacade();
            return pcFacade.PlayerTypes().ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
