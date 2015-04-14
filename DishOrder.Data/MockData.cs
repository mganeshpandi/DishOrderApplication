using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DishOrder.Entity;

namespace DishOrder.Data
{
    public class MockData
    {
        public List<IDish> DishesLookups()
        {
            List<IDish> dishes = new List<IDish>();
            DishCreateFactory factory = new DishCreateFactory();
            IDish dish;
            dish = factory.CreateDish();
            dish.DishName = "Egg";
            dish.DineTime = DiningTime.MORNING;
            dish.DishType =  DishType.Entry;
            dish.OrderLimit = "1";
            dishes.Add(dish);

            dish = factory.CreateDish();
            dish.DishName = "Toast";
            dish.DineTime = DiningTime.MORNING;
            dish.DishType =  DishType.Side;
            dish.OrderLimit = "1";
            dishes.Add(dish);

            dish = factory.CreateDish();
            dish.DishName = "Coffee";
            dish.DineTime = DiningTime.MORNING;
            dish.DishType =  DishType.Drink;
            dish.OrderLimit = "*";
            dishes.Add(dish);

            dish = factory.CreateDish();
            dish.DishName = "Steak";
            dish.DineTime = DiningTime.NIGHT;
            dish.DishType =  DishType.Entry;
            dish.OrderLimit = "1";
            dishes.Add(dish);

            dish = factory.CreateDish();
            dish.DishName = "Potato";
            dish.DineTime = DiningTime.NIGHT;
            dish.DishType =  DishType.Side;
            dish.OrderLimit = "*";
            dishes.Add(dish);

            dish = factory.CreateDish();
            dish.DishName = "Wine";
            dish.DineTime = DiningTime.NIGHT;
            dish.DishType =  DishType.Drink;
            dish.OrderLimit = "1";
            dishes.Add(dish);

            dish = factory.CreateDish();
            dish.DishName = "Cake";
            dish.DineTime = DiningTime.NIGHT;
            dish.DishType =  DishType.Dessert;
            dish.OrderLimit = "1";
            dishes.Add(dish);
           
            return dishes;
        }

        public static List<DishType> dishTypes()
        {            
            var obj= ((DishType[])Enum.GetValues(typeof(DishType))).OrderBy(p => p).ToList();
            return obj;
        }
    }
}
