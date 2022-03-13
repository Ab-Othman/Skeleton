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

            int TestData = 123;

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

        [TestMethod]
        public void FindMethodOK()
        {
            //create instance of clsOrder
            clsOrder anOrder = new clsOrder();
            //Boolean variable to store results of validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            Found = anOrder.Find(OrderNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
 
        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance
            clsOrder anOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create test data
            Int32 OrderNo = 1;
            //invoke the method
            Found = anOrder.Find(OrderNo);
            //check the order no
            if (anOrder.OrderNo != 1)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerUserIdFound()
        {
            //create an instance
            clsOrder anOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create test data
            Int32 OrderNo = 1;
            //invoke the method
            Found = anOrder.Find(OrderNo);
            //check the order no
            if (anOrder.CustomerUserId != 1)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance
            clsOrder anOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create test data
            Int32 OrderNo = 1;
            //invoke the method
            Found = anOrder.Find(OrderNo);
            //check the order no
            if (anOrder.OrderDate != Convert.ToDateTime("15/08/2000"))
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShippingAddressFound()
        {
            //create an instance
            clsOrder anOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create test data
            Int32 OrderNo = 1;
            //invoke the method
            Found = anOrder.Find(OrderNo);
            //check the order no
            if (anOrder.ShippingAddress != "123 House")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymenntMethodFound()
        {
            //create an instance
            clsOrder anOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create test data
            Int32 OrderNo = 1;
            //invoke the method
            Found = anOrder.Find(OrderNo);
            //check the order no
            if (anOrder.PaymentMethod != "Card")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentReceivedFound()
        {
            //create an instance
            clsOrder anOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create test data
            Int32 OrderNo = 1;
            //invoke the method
            Found = anOrder.Find(OrderNo);
            //check the order no
            if (anOrder.PaymentReceived != true)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            //create an instance
            clsOrder anOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create test data
            Int32 OrderNo = 1;
            //invoke the method
            Found = anOrder.Find(OrderNo);
            //check the order no
            if (anOrder.OrderStatus != "Processed")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }
    }
}
