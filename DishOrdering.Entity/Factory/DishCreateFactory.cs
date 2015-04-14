using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DishOrder.Entity
{
    public class DishCreateFactory : IDishCreateFactory
    {
        public IDish CreateDish()
        {
            return new Dish();
        }

        //public IDish CreateDish(DiningTime dineTime, DishType dishType, string dishName)
        //{
        //    IDish dish = new Dish(dineTime, dishType, dishName);            
        //    return dish;
        //}

        //public IDish CreateNightDish(DiningTime dineTime, DishType dishType, string dishName, string orderLimit)
        //{            
        //    IDish dish = new Dish(dineTime, dishType, dishName); 
        //    return dish;   
        //}
    }
}
