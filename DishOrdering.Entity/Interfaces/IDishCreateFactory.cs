using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DishOrder.Entity
{
    public interface IDishCreateFactory
    {
        IDish CreateDish();        
    }
}
