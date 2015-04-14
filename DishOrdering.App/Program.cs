using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DishOrder.Entity;
using DishOrder.Entity.Interfaces;
using DishOrder.BL;

namespace DishOrder.UI
{
    class Program
    {
        static void Main(string[] args)
        {
           try 
	        {	        
		         if (args.Length > 0)
                    {                  
                        DishOrderFactory factory = new DishOrderFactory();
                        IDishOrder dishOrderBL = factory.CreateDishOrderBL();
                        string result = dishOrderBL.Order(args);

                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("No paramater provided");
                    }
                 Console.ReadLine();
	        }
	        catch (Exception)
	        {
                Console.WriteLine("Exception Occurred. Please check your input");
	        }
        }
      
    }
}
