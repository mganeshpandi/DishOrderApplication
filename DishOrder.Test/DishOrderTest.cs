using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DishOrder.BL;
using DishOrder.Entity;
using DishOrder.Entity.Interfaces;
namespace DishOrder.Test
{
    [TestClass]
    public class DishOrderTest
    {
        DishOrderFactory _factory;
        IDishOrder dishOrderBL;
        [TestInitialize]
        public void TestInitialize()
        {
            _factory = new DishOrderFactory();
            dishOrderBL = _factory.CreateDishOrderBL();
        }

        [TestMethod]
        public void TestOrderDishMorning1()
        {   
            string[] input = {"morning","1","2","3"};

            string result = dishOrderBL.Order(input);

            Assert.AreEqual(result, "Output: Egg, Toast, Coffee");
        }

        [TestMethod]
        public void TestOrderDishMorning2()
        {            
            string[] input = { "morning", "2", "1", "3" };

            string result = dishOrderBL.Order(input);

            Assert.AreEqual(result, "Output: Egg, Toast, Coffee");
        }

        [TestMethod]
        public void TestOrderDishMorning3()
        {
            string[] input = { "morning", "1", "2", "3", "4" };

            string result = dishOrderBL.Order(input);

            Assert.AreEqual(result, "Output: Egg, Toast, Coffee, error");
        }

        [TestMethod]
        public void TestOrderDishMorning4()
        {
            string[] input = { "morning", "1", "2", "3", "3", "3" };

            string result = dishOrderBL.Order(input);

            Assert.AreEqual(result, "Output: Egg, Toast, Coffee(x3)");
        }

        [TestMethod]
        public void TestOrderDishNight1()
        {
            string[] input = { "night", "1", "2", "3", "4" };

            string result = dishOrderBL.Order(input);

            Assert.AreEqual(result, "Output: Steak, Potato, Wine, Cake");
        }

        [TestMethod]
        public void TestOrderDishNight2()
        {
            string[] input = { "night", "1", "2", "2", "4" };

            string result = dishOrderBL.Order(input);

            Assert.AreEqual(result, "Output: Steak, Potato(x2), Cake");
        }

        [TestMethod]
        public void TestOrderDishNight3()
        {
            string[] input = { "night", "1", "2", "3", "5" };

            string result = dishOrderBL.Order(input);

            Assert.AreEqual(result, "Output: Steak, Potato, Wine, error");
        }

        [TestMethod]
        public void TestOrderDishNight4()
        {
            string[] input = { "night", "1", "1", "2", "3", "5" };

            string result = dishOrderBL.Order(input);

            Assert.AreEqual(result, "Output: Steak, error");
        }
    }
}
