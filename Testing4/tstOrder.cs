using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create insatnce of class want to create
            clsOrder anOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(anOrder);
        }

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create insatnce of class want to create
            clsOrder anOrder = new clsOrder();

            int TestData = 0001;

            anOrder.OrderNo = TestData;

            Assert.AreEqual(anOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void CustomerUserIdPropertyOK()
        {
            //create insatnce of class want to create
            clsOrder anOrder = new clsOrder();

            string TestData = "Username123";

            anOrder.CustomerUserId = TestData;

            Assert.AreEqual(anOrder.CustomerUserId, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create insatnce of class want to create
            clsOrder anOrder = new clsOrder();

            DateTime TestData = DateTime.Now.Date;

            anOrder.OrderDate = TestData;

            Assert.AreEqual(anOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void ShippingAddressPropertyOK()
        {
            //create insatnce of class want to create
            clsOrder anOrder = new clsOrder();

            string TestData = "123 Home Way, LE1 1AB";

            anOrder.ShippingAddress = TestData;

            Assert.AreEqual(anOrder.ShippingAddress, TestData);
        }

        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            //create insatnce of class want to create
            clsOrder anOrder = new clsOrder();

            string TestData = "Debit card";

            anOrder.PaymentMethod = TestData;

            Assert.AreEqual(anOrder.PaymentMethod, TestData);
        }

        [TestMethod]
        public void PaymentReceivedPropertyOK()
        {
            //create insatnce of class want to create
            clsOrder anOrder = new clsOrder();

            bool TestData = true;

            anOrder.PaymentReceived = TestData;

            Assert.AreEqual(anOrder.PaymentReceived, TestData);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //create insatnce of class want to create
            clsOrder anOrder = new clsOrder();

            string TestData = "Delivered.";

            anOrder.OrderStatus = TestData;

            Assert.AreEqual(anOrder.OrderStatus, TestData);
        }
    }
}
