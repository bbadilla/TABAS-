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
   
        [Route("api/[controller]")]
        [ApiController]
        public class BagCartController : Controller
        {
            private readonly I_BagCart _contactMasterRepo;

            public BagCartController(I_BagCart contactMasterRepo)
            {
                _contactMasterRepo = contactMasterRepo;
            }

        [HttpGet]
        public ActionResult<List<BagCart>> GetAll()
        {
            return _contactMasterRepo.GetAll();
        }


        //[HttpPost]
        //public async Task<ActionResult<User>> Edit([FromBody]User contactMaster)
        //{
        //    if (contactMaster == null || !ModelState.IsValid)
        //    {
        //        return BadRequest("Invalid State");
        //    }

        //    return await _contactMasterRepo.Edit(contactMaster);
        //}


    }
    
}