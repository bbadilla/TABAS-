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
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly I_User _contactMasterRepo;

        public UserController(I_User contactMasterRepo)
        {
            _contactMasterRepo = contactMasterRepo;
        }

        [HttpGet("{id1}/{id2}")]
        public async Task<ActionResult<User>> GetByID(string id1, string id2)
        {
            return await _contactMasterRepo.GetByID(id1, id2);
        }
    }
}