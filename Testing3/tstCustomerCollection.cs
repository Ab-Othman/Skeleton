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
    }
}
