using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing4
{

    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the order collection class
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.PaymentReceived = true;
            TestItem.OrderNo = 1;
            TestItem.CustomerUserId = 1;
            TestItem.ShippingAddress = "123 house street";
            TestItem.PaymentMethod = "Card";
            TestItem.OrderStatus = "Processed";
            TestItem.OrderDate = DateTime.Now.Date;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to property
            AllOrders.OrderList = TestList;
            //test to see values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object 
            TestOrder.PaymentReceived = true;
            TestOrder.OrderNo = 1;
            TestOrder.CustomerUserId = 1;
            TestOrder.ShippingAddress = "123 house street";
            TestOrder.PaymentMethod = "Card";
            TestOrder.OrderStatus = "Processed";
            TestOrder.OrderDate = DateTime.Now.Date;
            //assign data to property
            AllOrders.ThisOrder = TestOrder;
            //test to see values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the clsOrderCollection
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //data must be a list of objects 
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //set its properties 
            TestItem.PaymentReceived = true;
            TestItem.OrderNo = 1;
            TestItem.CustomerUserId = 1;
            TestItem.ShippingAddress = "123 house street";
            TestItem.PaymentMethod = "Card";
            TestItem.OrderStatus = "Processed";
            TestItem.OrderDate = DateTime.Now.Date;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to the property
            AllOrders.OrderList = TestList;
            //test to see values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PaymentReceived = true;
            TestItem.OrderNo = 1;
            TestItem.CustomerUserId = 1;
            TestItem.ShippingAddress = "123 house street";
            TestItem.PaymentMethod = "Card";
            TestItem.OrderStatus = "Processed";
            TestItem.OrderDate = DateTime.Now.Date;
            //set ThisOrder to test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set primary key to test data
            TestItem.OrderNo = PrimaryKey;
            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create item of test data
            clsOrder TestItem = new clsOrder();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its property 
            TestItem.PaymentReceived = true;
            TestItem.CustomerUserId = 1;
            TestItem.ShippingAddress = "123 house street";
            TestItem.PaymentMethod = "Card";
            TestItem.OrderStatus = "Processed";
            TestItem.OrderDate = DateTime.Now.Date;
            //set ThisOrder to test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set primary key to test data
            TestItem.OrderNo = PrimaryKey;
            //modify the test data
            TestItem.PaymentReceived = false;
            TestItem.CustomerUserId = 2;
            TestItem.ShippingAddress = "234 house road";
            TestItem.PaymentMethod = "Paypal";
            TestItem.OrderStatus = "Awaiting payment";
            TestItem.OrderDate = DateTime.Now.Date;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create item of test data
            clsOrder TestItem = new clsOrder();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its property 
            TestItem.OrderNo = 1;
            TestItem.PaymentReceived = true;
            TestItem.CustomerUserId = 1;
            TestItem.ShippingAddress = "123 house street";
            TestItem.PaymentMethod = "Card";
            TestItem.OrderStatus = "Processed";
            TestItem.OrderDate = DateTime.Now.Date;
            //set ThisOrder to test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set primary key to test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
    }
}
