using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishOrder.Entity
{
    class Dish : AbstractDish
    {
        public Dish()
        {

        }

        private DishType dishType;
        public override DishType DishType
        {
            get
            {
                return dishType;
            }
            set
            {
                if (DineTime == DiningTime.MORNING && DishType == Entity.DishType.Dessert)
                {
                    throw new NotSupportedException();
                }
                dishType = value;
            }
        }
    }
}