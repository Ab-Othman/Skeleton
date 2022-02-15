using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //test to see it exists
            Assert.IsNotNull(ASupplier); 
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign property
            Boolean TestData = true;
            //assign data to property
            ASupplier.Active = TestData;
            //test to see two values are the same
            Assert.AreEqual(ASupplier.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we are creating
            clsSupplier ASupplier = new clsSupplier();
            //create the test data for property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to property
            ASupplier.DateAdded = TestData;
            //test two values are the same
            Assert.AreEqual(ASupplier.DateAdded, TestData);
        }

        [TestMethod]
        public void ShippingFromAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data for property
            string TestData = "UK";
            //Assign data to property 
            ASupplier.ShippingFromAddress = TestData;
            //test to see two values are the same 
            Assert.AreEqual(ASupplier.ShippingFromAddress, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //Create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create test data
            string TestData = "07982345289";
            //assign data to property
            ASupplier.PhoneNumber = TestData;
            //test to see two values the same
            Assert.AreEqual(ASupplier.PhoneNumber, TestData);
        }

        [TestMethod]

        public void SupplierIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //create test data
            Int32 TestData = 1;
            //assign data to property
            ASupplier.SupplierID = TestData;
            //test to see two values the same
            Assert.AreEqual(ASupplier.SupplierID, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create test data
            string TestData = "huawei@huawei.com";
            //assign data to property
            ASupplier.Email = TestData;
            //test to see two values the same
            Assert.AreEqual(ASupplier.Email, TestData);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create test data
            string TestData = "samsung";
            //assign data to property
            ASupplier.SupplierName = TestData;
            //test to see two values the same
            Assert.AreEqual(ASupplier.SupplierName, TestData);
            }
    }   
}
