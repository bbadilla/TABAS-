using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Registros.Logic;
using API_Registros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Registros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaletaController : Controller
    {
        private readonly I_Maleta _contactMasterRepo;

        public MaletaController(I_Maleta contactMasterRepo)
        {
            _contactMasterRepo = contactMasterRepo;
        }



        [HttpPost]
        public ActionResult<Maleta> Create([FromBody]Maleta contactMaster)
        {
            if (contactMaster == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid State");
            }

            return _contactMasterRepo.Create(contactMaster);
        }

    }
}