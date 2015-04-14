using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishOrder.Entity.Interfaces
{
    public interface IDishOrder
    {
        string Order(string[] args);        
    }
}
