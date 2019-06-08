using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Escaneo.Logic;
using API_Escaneo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Escaneo.Controllers
{

    [ApiController]
    public class MaletaController : Controller
    {
        private readonly I_Maleta _contactMasterRepo;

        public MaletaController(I_Maleta contactMasterRepo)
        {
            _contactMasterRepo = contactMasterRepo;
        }



        [Route("api/[controller]/asign_BC")]
        [HttpPut]
        public ActionResult<Maleta> Asign_BC([FromBody]Maleta contactMaster)
        {
            if (contactMaster == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid State");
            }

            return _contactMasterRepo.Asign_BC(contactMaster);
        }

        [Route("api/[controller]/asign_airship")]
        [HttpPut]
        public ActionResult<Maleta> Asign_airship([FromBody]Maleta contactMaster)
        {
            if (contactMaster == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid State");
            }

            return _contactMasterRepo.Asign_airship(contactMaster);
        }

    }
}