using DishOrder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DishOrder.Entity;
using DishOrder.Entity.Interfaces;
namespace DishOrder.BL
{
    public class DishOrderBL: IDishOrder
    {
        public string Order(string[] args)
        {
            try
            {
                if (args.Length > 0)
                {
                    IDishCreateFactory factory;
                    factory = new DishCreateFactory();
                    List<IDish> dishes = new List<IDish>();
                    List<IDish> dishesLookup;
                    string dineTime = args[0].ToString().Replace(",", "");

                    dishesLookup = MockDataBL.GetDishesLookup();

                    for (int i = 1; i < args.Length; i++)
                    {

                        var filteredDishes = dishesLookup.Where(p => p.DineTime == (DiningTime)Enum.Parse(typeof(DiningTime), dineTime.ToUpper()) && p.DishType == (DishType)Convert.ToInt32(args[i].Replace(",", "")));
                        if (filteredDishes.Any() == true)
                        {
                            dishes.Add(filteredDishes.First());
                        }
                        else
                        {
                            var invalidDish = factory.CreateDish();
                            invalidDish.IsValid = true;
                            dishes.Add(invalidDish);
                        }
                    }
                    var invalidDishes = dishes.Where(p => p.IsValid == true);
                    var validatedDishes = ValidateDish.ValidateDishRules((DiningTime)Enum.Parse(typeof(DiningTime), dineTime.ToUpper()), dishes.Where(p => p.IsValid == false).ToList<IDish>());


                    foreach (var invalidDish in invalidDishes)
                    {
                        validatedDishes.Add(invalidDish);
                    }

                    return PrintOutput(validatedDishes);
                }
                else
                {
                    return "No paramater provided";
                }
            }
            catch (Exception)
            {                
                throw;
            }
        }

        private static string PrintOutput(List<IDish> dishes)
        {
            StringBuilder sbrOutput = new StringBuilder();
            sbrOutput.Append("Output: ");
            var dishLookup = MockDataBL.GetDishesLookup();
            foreach (var dish in dishes)
            {
                if (dish.IsValid == false)
                {
                    if (dish.OrderLimit == "*"  && dishes.Where(p=> p.DishName == dish.DishName).Count() > 1)
                    {
                        if (sbrOutput.ToString().Contains(dish.DishName + "(x") == false)
                        {
                            int dishCount = dishes.Where(p => p.DishName == dish.DishName).Count();
                            sbrOutput.Append(dish.DishName + "(x" + dishCount.ToString() + "), ");
                        }
                    }
                    else
                    {
                        sbrOutput.Append(dish.DishName + ", ");
                    }
                }
                else
                {
                    if (dish.OrderLimit == "1" && sbrOutput.ToString().Contains(dish.DishName + ",") == false)
                    {
                        sbrOutput.Append(dish.DishName + ", ");
                    }
                    else
                    {
                        sbrOutput.Append("error");
                        break;
                    }
                }
            }
            string output = sbrOutput.ToString().TrimEnd(' ');
            return output.TrimEnd(',');
        }

       
    }
}
