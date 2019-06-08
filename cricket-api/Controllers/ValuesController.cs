using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlayCricket.Data.Model;
using PlayCricket.DataReader;
using PlayCricket.Facade;
using PlayCricket.Models;

namespace cricket_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private PlayCricketContext PlayCricketContext { get; set; }
        public ValuesController(PlayCricketContext context)
        {
            PlayCricketContext = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<PlayerTypeModel>> GetPlayerTypes()
        {
            PlayCricketFacade pcFacade = new PlayCricketFacade(this.PlayCricketContext);
            return pcFacade.PlayerTypes().ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
