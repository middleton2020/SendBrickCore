using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.SendBrickCore.FunctionModules.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.SendBrickCoreTests.FunctionModules.Orders;

namespace CM.SendBrickCore.FunctionModules.Orders.Tests
{
    [TestClass()]
    public class OrderManagerTests
    {
        [TestMethod()]
        public void AddOrderTest()
        {
            OrderManager orderManager = new OrderManager();

            OrderData order1 = new OrderData();
            order1 = (OrderData)SampleOrder1.PopulateOrder(order1);
            int index1 = orderManager.AddOrder(order1);

            OrderData order2 = new OrderData();
            order2 = (OrderData)SampleOrder2.PopulateOrder(order2);
            int index2 = orderManager.AddOrder(order2);

            OrderData order3 = new OrderData();
            order3 = (OrderData)SampleOrder3.PopulateOrder(order3);
            int index3 = orderManager.AddOrder(order3);

            Assert.AreEqual(0, index1);
            Assert.AreEqual(1, index2);
            Assert.AreEqual(2, index3);
            Assert.AreEqual(order2, orderManager.GetOrder(index2));
        }

        [TestMethod()]
        public void GetOrderTest()
        {
            OrderManager orderManager = new OrderManager();

            OrderData order1 = new OrderData();
            order1 = (OrderData)SampleOrder1.PopulateOrder(order1);
            int index1 = orderManager.AddOrder(order1);

            OrderData order2 = new OrderData();
            order2 = (OrderData)SampleOrder2.PopulateOrder(order2);
            int index2 = orderManager.AddOrder(order2);

            OrderData order3 = new OrderData();
            order3 = (OrderData)SampleOrder3.PopulateOrder(order3);
            int index3 = orderManager.AddOrder(order3);

            Assert.AreEqual(order1, orderManager.GetOrder(index1));
            Assert.AreEqual(order2, orderManager.GetOrder(index2));
            Assert.AreEqual(order3, orderManager.GetOrder(index3));

            // Make sure that you set the corrrect item to reference in the order.
            ((OrderData)orderManager.GetOrder(index2)).FindFirstItem();
            Assert.AreEqual(SampleOrder2.Item1SkuCode, orderManager.GetOrder(index2).ItemSkuCode);
        }
    }
}