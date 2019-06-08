using API_Escaneo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Escaneo.Logic
{
    public interface I_User
    {
        Task<User> GetByID(string paramero1, string parametro2);
    }
}
