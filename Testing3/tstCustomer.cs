using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create test data to pass method

        string CustomerFullName = "Nidhi Stevens";
        string CustomerPhoneNumber = "277091025";
        string CustomerEmailId = "nidhi.stevens@gmail.com";
        string CustomerAccountCreated = DateTime.Now.Date.ToString();
        string CustomerAddress = "Kew Drive, Leicester, LE3 4TY";        


        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //test to see tha it exists 
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerUserIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            int TestData = 1;
            //assign the data to the property 
            ACustomer.CustomerUserId = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.CustomerUserId, TestData);
        }

        [TestMethod]
        public void CustomerFullNamePropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "Nidhi Stevens";

            ACustomer.CustomerFullName = TestData;

            Assert.AreEqual(ACustomer.CustomerFullName, TestData);
        }

        [TestMethod]
        public void CustomerPhoneNumberPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "277091025";

            ACustomer.CustomerPhoneNumber = TestData;

            Assert.AreEqual(ACustomer.CustomerPhoneNumber, TestData);
        }

        [TestMethod]
        public void CustomerEmailIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "nidhi.stevens@gmail.com";

            ACustomer.CustomerEmailId = TestData;

            Assert.AreEqual(ACustomer.CustomerEmailId, TestData);
        }

        [TestMethod]
        public void CustomerAccountCreatedPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            DateTime TestData = DateTime.Now.Date;

            ACustomer.CustomerAccountCreated = TestData;

            Assert.AreEqual(ACustomer.CustomerAccountCreated, TestData);
        }

        [TestMethod]
        public void CustomerAddressOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "Kew Drive, Leicester, LE3 4TY.";

            ACustomer.CustomerAddress = TestData;

            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }
       
        [TestMethod]
        public void SubscribedToReceiveMailPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            Boolean TestData = true;

            ACustomer.SubscribedToReceiveMail = TestData;

            Assert.AreEqual(ACustomer.SubscribedToReceiveMail, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Int32 CustomerUserId = 1;

            Found = ACustomer.Find(CustomerUserId);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerUserIdFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerUserId = 1;

            Found = ACustomer.Find(CustomerUserId);

            if(ACustomer.CustomerUserId != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerFullNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerUserId = 1;

            Found = ACustomer.Find(CustomerUserId);

            if(ACustomer.CustomerFullName != "Nidhi Stevens")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPhoneNumberFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerUserId = 1;

            Found = ACustomer.Find(CustomerUserId);

            if (ACustomer.CustomerPhoneNumber != "277091025")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerEmailIdFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerUserId = 1;

            Found = ACustomer.Find(CustomerUserId);

            if (ACustomer.CustomerEmailId != "nidhi.stevens@gmail.com")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAccountCreatedFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerUserId = 1;

            Found = ACustomer.Find(CustomerUserId);

            if (ACustomer.CustomerAccountCreated != Convert.ToDateTime("26/07/2002"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerUserId = 1;

            Found = ACustomer.Find(CustomerUserId);

            if (ACustomer.CustomerAddress != "Kew Drive, Leicester, LE3 4TY.")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSubscribedToReceiveMailFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerUserId = 1;

            Found = ACustomer.Find(CustomerUserId);

            if (ACustomer.SubscribedToReceiveMail != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
       public void CustomerFullNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerFullName = "";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerFullName = "a";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerFullName = "aa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerFullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerFullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullnameMid()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerFullName = "aaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerFullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerFullName = "";
            CustomerFullName = CustomerFullName.PadRight(200, 'a');

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerPhoneNumber = "";            

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMin()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerPhoneNumber = "a";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerPhoneNumber = "aa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerPhoneNumber = "aaaaaaaaaaaaaa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerPhoneNumber = "aaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerPhoneNumber = "aaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMid()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerPhoneNumber = "aaaaaaaa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerPhoneNumber = "";
            CustomerPhoneNumber = CustomerPhoneNumber.PadRight(100, 'a');

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailIdMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerEmailId = "";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailIdMin()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerEmailId = "a";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailIdMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerEmailId = "aa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailIdMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerEmailId = "01234567890123456789012345678";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailIdMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerEmailId = "012345678901234567890123456789";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailIdMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerEmailId = "0123456789012345678901234567890";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailIdMid()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerEmailId = "012345678901234";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailIdExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerEmailId = "";
            CustomerEmailId = CustomerEmailId.PadRight(200, 'a');

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAccountCreatedExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);

            //change the date variable to sring variable
            string CustomerAccountCreated = TestDate.ToString();

            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAccountCreatedMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);

            //change the date variable to sring variable
            string CustomerAccountCreated = TestDate.ToString();
            
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAccountCreatedMin()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;
            
            //change the date variable to string variable
            string CustomerAccountCreated = TestDate.ToString();

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAccountCreatedMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(1);

            //change the date variable to string variable
            string CustomerAccountCreated = TestDate.ToString();

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAccountCreatedExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);

            //change the date variable to string variable
            string CustomerAccountCreated = TestDate.ToString();

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAccountCreatedInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";

            String CustomerAccountCreated = "this is not a date!";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerAddress = "";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerAddress = "a";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerAddress = "aa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(200, 'a');

            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);

            Assert.AreNotEqual(Error, "");
        }

    }
}
