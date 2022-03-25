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

    }
}
