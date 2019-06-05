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
        //Task<BagCart> Edit(BagCart user);
    }
}
