using API_Escaneo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Escaneo.Logic
{
    public interface I_Maleta
    {
        Maleta Asign_BC(Maleta maleta);
        Maleta Asign_airship(Maleta maleta);
    }
}
