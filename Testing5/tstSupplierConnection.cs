using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    { 
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test to see it exists
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            //create an instance of the class we wnt to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.Active = true;
            TestItem.SupplierID = 3;
            TestItem.SupplierName = "huawei";
            TestItem.Email = "huawei@huawei.co.uk";
            TestItem.ShippingFromAddress = "China";
            TestItem.PhoneNumber = "07559983467";
            TestItem.DateAdded = DateTime.Now.Date;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to property
            AllSuppliers.SupplierList = TestList;
            //test to see values are the same
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            //create an instance of the class we want to create 
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign the property
            clsSupplier TestSupplier = new clsSupplier();
            //set the properties of the test object 
            TestSupplier.Active = true;
            TestSupplier.SupplierID = 3;
            TestSupplier.SupplierName = "huawei";
            TestSupplier.Email = "huawei@huawei.co.uk";
            TestSupplier.ShippingFromAddress = "China";
            TestSupplier.PhoneNumber = "07559983467";
            TestSupplier.DateAdded = DateTime.Now.Date;
            //assign data to property
            AllSuppliers.ThisSupplier = TestSupplier;
            //test to see values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            //data needs to be a list of objects 
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties 
            TestItem.Active = true;
            TestItem.SupplierID = 3;
            TestItem.SupplierName = "huawei";
            TestItem.Email = "huawei@huawei.co.uk";
            TestItem.ShippingFromAddress = "China";
            TestItem.PhoneNumber = "07559983467";
            TestItem.DateAdded = DateTime.Now.Date;
            //add item to test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSuppliers.SupplierList = TestList;
            //test to see values are the same
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.SupplierID = 3;
            TestItem.SupplierName = "huawei";
            TestItem.Email = "huawei@huawei.co.uk";
            TestItem.ShippingFromAddress = "China";
            TestItem.PhoneNumber = "07559983467";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisSupplier to test data
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set primary key to test data
            TestItem.SupplierID = PrimaryKey;
            //find the record 
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create item of test data
            clsSupplier TestItem = new clsSupplier();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its property 
            TestItem.Active = true;
            TestItem.SupplierID = 3;
            TestItem.SupplierName = "huawei";
            TestItem.Email = "huawei@huawei.co.uk";
            TestItem.ShippingFromAddress = "China";
            TestItem.PhoneNumber = "07559983467";
            TestItem.DateAdded = DateTime.Now.Date;
            //set thisSupplier to test data
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set primary key to test data
            TestItem.SupplierID = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "apple";
            TestItem.Email = "apple@gmail.com";
            TestItem.ShippingFromAddress = "UK";
            TestItem.PhoneNumber = "07982345289";
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the new test data
            AllSuppliers.ThisSupplier = TestItem;
            //update the record
            AllSuppliers.Update();
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see thisSupplier matches test data
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }
    }
}
