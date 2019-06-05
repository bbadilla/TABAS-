using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Registros.Data
{
    public interface I_User
    {
        Task<User> GetByID(string paramero1, string parametro2);
        Task<User> Edit(User user);
    }

}
