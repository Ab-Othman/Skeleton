using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        //OrderDate, ShippingAddress, PaymentMethod, OrderStatus
        string OrderDate = DateTime.Now.Date.ToString();
        string ShippingAddress = "123 House Street";
        string PaymentMethod = "Card";
        string OrderStatus = "Order Processed";

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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke method 
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the OrderDate to a non date value
            string OrderDate = "definately not a date!";
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "a"; 
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "aa"; 
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(49, 'a'); //PadRight just saves having to manually type out 49 'a'
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(50, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(51, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMid()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(25, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(500, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentMethod = "";
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentMethod = "a";
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentMethod = "aa";
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentMethodMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentMethod = "aaaaaaaaa";
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentMethod = "aaaaaaaaaa";
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentMethod = "aaaaaaaaaaa";
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMid()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentMethod = "aaaaa";
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentMethod = "";
            PaymentMethod = PaymentMethod.PadRight(500, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "";
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "a";
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "aa";
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderStatusMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(19, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(20, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(21, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMid()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(10, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(500, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
