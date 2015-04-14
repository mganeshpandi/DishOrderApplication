using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DishOrder.Entity
{
    abstract class AbstractDish : IDish
    {
        public string OrderLimit { get; set; }

        public string DishName { get; set; }

        public virtual DishType DishType { get; set; }

        public DiningTime DineTime { get; set; }


        public void OrderDish()
        {
            throw new NotImplementedException();
        }

        public bool IsValid { get; set; }
    }
}
