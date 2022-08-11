using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStockCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data neeeds to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Availability = true;
            TestItem.PhoneNo = 1;
            TestItem.PhoneDescription = "Some description";
            TestItem.PhoneColour = "Some phone colour";
            TestItem.DateReleased = DateTime.Now.Date;
            TestItem.Price = (double)499.99;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);

        }


        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.Availability = true;
            TestStock.PhoneNo = 1;
            TestStock.PhoneDescription = "Some description";
            TestStock.PhoneColour = "Some phone colour";
            TestStock.DateReleased = DateTime.Now.Date;
            TestStock.Price = 499.99;
            //assign the data to the property
            AllStocks.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties 
            TestItem.Availability = true;
            TestItem.PhoneNo = 1;
            TestItem.PhoneDescription = "Some description";
            TestItem.PhoneColour = "Some phone colour";
            TestItem.DateReleased = DateTime.Now.Date;
            TestItem.Price = 499.99;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Availability = true;
            TestItem.PhoneNo = 1;
            TestItem.PhoneDescription = "some description";
            TestItem.PhoneColour = "some colour";
            TestItem.DateReleased = DateTime.Now.Date;
            TestItem.Price = (double)499.99;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.PhoneNo = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Availability = true;
            TestItem.PhoneNo = 1;
            TestItem.PhoneDescription = "some description";
            TestItem.PhoneColour = "some colour";
            TestItem.DateReleased = DateTime.Now.Date;
            TestItem.Price = (double)499.99;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            TestItem.PhoneNo = PrimaryKey;
            TestItem.Availability = false;
            TestItem.PhoneDescription = "another description";
            TestItem.PhoneColour = "Another Colour";
            TestItem.DateReleased = DateTime.Now.Date;
            TestItem.Price = (double)599.99;
            AllStocks.ThisStock = TestItem;
            AllStocks.Update();
            AllStocks.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Availability = true;
            TestItem.PhoneNo = 1;
            TestItem.PhoneDescription = "some description";
            TestItem.PhoneColour = "some colour";
            TestItem.DateReleased = DateTime.Now.Date;
            TestItem.Price = (double)499.99;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            TestItem.PhoneNo = PrimaryKey;
            AllStocks.ThisStock.Find(PrimaryKey);
            AllStocks.Delete();
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPhoneColourMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.ReportByPhoneColour("");
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);

        }

        [TestMethod]
        public void ReportByPhoneColourNoneFound()
        {
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.ReportByPhoneColour("xxx xxx");
            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByPhoneColourTestDataFound()
        {
            clsStockCollection FilteredStocks = new clsStockCollection();
            Boolean OK = true;
            FilteredStocks.ReportByPhoneColour("yyy yyy");
            if (FilteredStocks.Count == 2)
            {
                if (FilteredStocks.StockList[0].PhoneNo != 36)
                {
                    OK = false;
                }
                if (FilteredStocks.StockList[1].PhoneNo != 37)
                {
                    OK = false;

                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



    }   
}
