using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {

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

        public void TestCustomerAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerUserId = 1;

            Found = ACustomer.Find(CustomerUserId);

            if (ACustomer.CustomerAddress != "Kew Drive, Leicester, LE3 4TY")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

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

    }
}
