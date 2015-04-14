using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DishOrder.Entity;
using DishOrder.Data;
namespace DishOrder.BL
{
    public static class ValidateDish
    {

        public static List<IDish> ValidateDishRules(DiningTime dineTime, List<IDish> dishes)
        {
            List<IDish> dishesLookup = MockDataBL.GetDishesLookup();
            var filteredDishes = dishesLookup.Where(p => p.DineTime == dineTime);

            foreach (var dish in dishes)
            {
                if (dishesLookup.Where(p => p.DishName == dish.DishName).Any() == false)
                {
                    dish.IsValid = true;
                }
                if (dishesLookup.Where(p => p.DishName == dish.DishName).Any() == true)
                {
                    var dishFromLookup = dishesLookup.Where(p => p.DishName == dish.DishName).Single();
                    if (dishFromLookup.OrderLimit != "*" && dishes.Where(p => p.DishName == dish.DishName).Count() > 1)
                    {
                        dish.IsValid = true;
                    }
                }
            }
            return dishes.OrderBy(p => p.DishType).ToList<IDish>();
        }
    }
}
