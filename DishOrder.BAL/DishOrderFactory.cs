using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DishOrder.Entity.Interfaces;
namespace DishOrder.BL
{
    public class DishOrderFactory
    {
        public IDishOrder CreateDishOrderBL()
        {
            return new DishOrderBL();
        }
    }
}
