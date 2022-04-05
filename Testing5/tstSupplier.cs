using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstSupplier

    {
        //good test data
        //create test data to pass method
        string PhoneNumber = "07559983467";
        string Email = "huawei@huawei.co.uk";
        string DateAdded = DateTime.Now.Date.ToString();
        string ShippingFromAddress = "China";
        string SupplierName = "huawei";



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
            Assert.AreEqual(ASupplier.Active, true);
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
        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we are creating
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the results of validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SupplierID = 4;
            //invoke the method
            Found = ASupplier.Find(SupplierID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplierIDFound()
        {
            //create an instance
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create test data
            Int32 SupplierID = 4;
            //invoke the method
            Found = ASupplier.Find(SupplierID);
            //check the supplier ID
            if (ASupplier.SupplierID != 4)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some tests data to use in method
            Int32 SupplierID = 4;
            //invoke the method
            Found = ASupplier.Find(SupplierID);
            //check property
            if (ASupplier.DateAdded != Convert.ToDateTime("15/08/2000"))
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierID = 4;
            //invoke the method
            Found = ASupplier.Find(SupplierID);
            //check the property
            if (ASupplier.Active != true)
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumber()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierID = 4;
            //invoke the method
            Found = ASupplier.Find(SupplierID);
            //check the property
            if (ASupplier.PhoneNumber != "07559983467")
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmail()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierID = 4;
            //invoke the method
            Found = ASupplier.Find(SupplierID);
            //check the property
            if (ASupplier.Email != "huawei@huawei.co.uk")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShippingFromAddress()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierID = 4;
            //invoke the method
            Found = ASupplier.Find(SupplierID);
            //check the property
            if (ASupplier.ShippingFromAddress != "China")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierName()
        {
            //create an instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with method
            Int32 SupplierID = 4;
            //invoke the method
            Found = ASupplier.Find(SupplierID);
            //check the property
            if (ASupplier.SupplierName != "huawei")
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
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store an error message
            String Error = "";
            //create some test data to pass the method
            string PhoneNumber = ""; //should trigger an error
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string PhoneNumber = "0";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string PhoneNumber = "07";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string PhoneNumber = "07897";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string PhoneNumber = "000000";
            //invoke the methd
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string PhoneNumber = "00000000";
            //invoke the methd
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string PhoneNumber = "0000000000000000";
            //invoke the methd
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //Create anm instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass method
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(500, '0');
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a avariable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "a";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aa";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //Create anm instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass method
            string Email = "";
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //Create anm instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass method
            string Email = "";
            Email = Email.PadRight(25, 'a');
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //Create anm instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass method
            string Email = "";
            Email = Email.PadRight(500, 'a');
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingFromAddressMinLessOne()
        {
            //create an instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShippingFromAddress = "";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingFromAddressMin()
        {
            //create an instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShippingFromAddress = "a";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingFromAddressMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShippingFromAddress = "aa";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingFromAddressMaxLessOne()
        {
            //Create anm instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass method
            string ShippingFromAddress = "";
            ShippingFromAddress = ShippingFromAddress.PadRight(49, 'a');
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingFromAddressMax()
        {
            //Create anm instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass method
            string ShippingFromAddress = "";
            ShippingFromAddress = ShippingFromAddress.PadRight(50, 'a');
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingFromAddressMaxPlusOne()
        {
            //Create anm instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass method
            string ShippingFromAddress = "";
            ShippingFromAddress = ShippingFromAddress.PadRight(50, 'a');
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingFromAddressMid()
        {
            //Create anm instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass method
            string ShippingFromAddress = "";
            ShippingFromAddress = ShippingFromAddress.PadRight(25, 'a');
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingFromAddressExtremeMax()
        {
            //Create anm instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass method
            string ShippingFromAddress = "";
            ShippingFromAddress = ShippingFromAddress.PadRight(500, 'a');
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }
  
        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string SupplierName = "";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            //create an instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string SupplierName = "a";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string SupplierName = "aa";
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            //Create anm instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(49, 'a');
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            //Create anm instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(50, 'a');
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            //Create anm instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(51, 'a');
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMid()
        {
            //Create anm instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(25, 'a');
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            //Create anm instance of the class we want to create 
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'a');
            //invoke the method
            Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

       
    }
    
}