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
        public class BagCartController : Controller
        {
            private readonly I_BagCart _contactMasterRepo;

            public BagCartController(I_BagCart contactMasterRepo)
            {
                _contactMasterRepo = contactMasterRepo;
            }
        [Route("api/[controller]")]
        [HttpGet]
        public ActionResult<List<BagCart>> GetAll()
        {
            return _contactMasterRepo.GetAll();
        }

        [Route("api/[controller]")]
        [HttpPost]
        public ActionResult<BagCart> Create([FromBody]BagCart contactMaster)
        {
            if (contactMaster == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid State");
            }

            return _contactMasterRepo.Create(contactMaster);
        }

        [Route("api/[controller]/asign")]
        [HttpPut]
        public ActionResult<BagCart> Asign_BC_flight([FromBody]BagCart contactMaster)
        {
            if (contactMaster == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid State");
            }

            return _contactMasterRepo.Asign_BC_Flight(contactMaster);
        }

        [Route("api/[controller]/close")]
        [HttpPut]
        public ActionResult<BagCart> Close_BC([FromBody]BagCart contactMaster)
        {
            if (contactMaster == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid State");
            }

            return _contactMasterRepo.Close_BC(contactMaster);
        }


    }

}