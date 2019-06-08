using API_Bagcart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Bagcart.Logic
{
    public interface I_BagCart
    {
        List<BagCart> GetAll();
        BagCart Create(BagCart bagbart);
        BagCart Asign_BC_Flight(BagCart bagcart);
        BagCart Close_BC(BagCart bagcart);
    }
}
