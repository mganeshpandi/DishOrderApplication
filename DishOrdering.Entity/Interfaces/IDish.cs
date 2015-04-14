using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DishOrder.Entity
{
    public interface IDish
    {
        string OrderLimit
        {
            get;
            set;
        }

        string DishName
        {
            get;
            set;
        }

        
        DishType DishType
        {
            get;
            set;
        }

        DiningTime DineTime
        {
            get;
            set;
        }

        bool IsValid
        {
            get;
            set;
        }
        void OrderDish();
    }
}
