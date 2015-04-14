using DishOrder.Data;
using DishOrder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishOrder.BL
{
    public static class MockDataBL
    {
        public static List<IDish> GetDishesLookup()
        {
            MockData dl = new MockData();
            return dl.DishesLookups();
        }
    }
}
