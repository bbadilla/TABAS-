using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Bagcart.Logic;
using API_Bagcart.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Bagcart.Controllers
    {
        
        [ApiController]
        public class FlightController : Controller
        {
            private readonly I_Flight _contactMasterRepo;

            public FlightController(I_Flight contactMasterRepo)
            {
                _contactMasterRepo = contactMasterRepo;
            }

    

        [Route("api/[controller]/asign")]
        [HttpPut]
        public ActionResult<Flight> Asign_airship([FromBody]Flight contactMaster)
        {
            if (contactMaster == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid State");
            }

            return _contactMasterRepo.Asign_airship(contactMaster);
        }

    }
}