using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance oof the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see f it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an intsance of class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();

            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();

            //set its properties
            TestItem.CustomerUserId = 1;
            TestItem.CustomerFullName = "Kittu Seetha";
            TestItem.CustomerPhoneNumber = "7474893455";
            TestItem.CustomerEmailId = "kittu.seetha@gmail.com";
            TestItem.CustomerAccountCreated = DateTime.Now.Date;
            TestItem.CustomerAddress = "LevField, Leicester, LE5 6UK";
            TestItem.SubscribedToReceiveMail = true;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an intsnace of class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();

            //set properties of the test object
            TestCustomer.CustomerUserId = 1;
            TestCustomer.CustomerFullName = "Kittu Seetha";
            TestCustomer.CustomerPhoneNumber = "7474893455";
            TestCustomer.CustomerEmailId = "kittu.seetha@gmail.com";
            TestCustomer.CustomerAccountCreated = DateTime.Now.Date;
            TestCustomer.CustomerAddress = "LevField, Leicester, LE5 6UK";
            TestCustomer.SubscribedToReceiveMail = true;

            AllCustomers.ThisCustomer = TestCustomer;

            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();

            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();

            //set its properties
            TestItem.CustomerUserId = 1;
            TestItem.CustomerFullName = "Kittu Seetha";
            TestItem.CustomerPhoneNumber = "7474893455";
            TestItem.CustomerEmailId = "kittu.seetha@gmail.com";
            TestItem.CustomerAccountCreated = DateTime.Now.Date;
            TestItem.CustomerAddress = "LevField, Leicester, LE5 6UK";
            TestItem.SubscribedToReceiveMail = true;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        //creating add update, delecte and filter

        [TestMethod]
        public void AddMethodOK()
        {
            //create an intsnace of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create the item of test data
            clsCustomer TestItem = new clsCustomer();

            //var to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.CustomerUserId = 1;
            TestItem.CustomerFullName = "Nidhi Stevens";
            TestItem.CustomerPhoneNumber = "277091025";
            TestItem.CustomerEmailId = "nidhi.stevens@gmail.com";
            TestItem.CustomerAccountCreated = DateTime.Now.Date;
            TestItem.CustomerAddress = "Kew Drive, Leicester, LE3 4TY";
            TestItem.SubscribedToReceiveMail = true;

            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;

            //add the record
            PrimaryKey = AllCustomers.Add();

            //set the primary key of the test data
            TestItem.CustomerUserId = PrimaryKey;

            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create the item of test data
            clsCustomer TestItem = new clsCustomer();

            //var to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.SubscribedToReceiveMail = true;
            TestItem.CustomerFullName = "Nidhi Stevens";
            TestItem.CustomerPhoneNumber = "277091025";
            TestItem.CustomerEmailId = "nidhi.stevens@gmail.com";
            TestItem.CustomerAddress = "Kew Drive, Leicester, LE3 4TY";
            TestItem.CustomerAccountCreated = DateTime.Now.Date;

            //set thiscustomer to  the test data
            AllCustomers.ThisCustomer = TestItem;

            //add the record
            PrimaryKey = AllCustomers.Add();

            //set the primary key of the test data
            TestItem.CustomerUserId = PrimaryKey;

            //modify the data
            TestItem.SubscribedToReceiveMail = false;
            TestItem.CustomerFullName = "Nidhi Sharma";
            TestItem.CustomerPhoneNumber = "277091026";
            TestItem.CustomerEmailId = "nidhi.sharma@gmail.com";
            TestItem.CustomerAddress = "Kew Drive, Leicester, LE5 6TY";
            TestItem.CustomerAccountCreated = DateTime.Now.Date;

            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the recoed
            AllCustomers.Update();

            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            //test to see thisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instace of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();

            //var to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.SubscribedToReceiveMail = true;
            TestItem.CustomerUserId = 1;
            TestItem.CustomerFullName = "Nidhi Stevens";
            TestItem.CustomerPhoneNumber = "277091025";
            TestItem.CustomerEmailId = "nidhi.stevens@gmail.com";
            TestItem.CustomerAddress = "Kew Drive, Leicester, LE3 4TY";
            TestItem.CustomerAccountCreated = DateTime.Now.Date;

            //set thisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;

            //add the record
            PrimaryKey = AllCustomers.Add();

            //set the prmary key of the test data
            TestItem.CustomerUserId = PrimaryKey;

            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            //delete the record
            AllCustomers.Delete();

            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCustomerFullNameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create an instanceof the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            //apply a blank string (Should return all records);
            FilteredCustomers.ReportByCustomerFullName("");

            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerFullNameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            //apply a Customer full name that doesn't exist
            FilteredCustomers.ReportByCustomerFullName("wwwwwww");

            //test to see that there are no records 
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerFullNameTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            //var to store outcome
            Boolean OK = true;

            //apply a post code that doesn't exist
            FilteredCustomers.ReportByCustomerFullName("Ohm Pawat");

            //check that the correct number of records are founf
            if(FilteredCustomers.Count == 2)
            {

                //check that the first record is ID 36
                if(FilteredCustomers.CustomerList[0].CustomerUserId != 66)
                {
                    OK = false;
                }
                //check that the first rec ord is ID 37
                if (FilteredCustomers.CustomerList[1].CustomerUserId != 67)
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
