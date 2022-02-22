using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
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
            String TestData = "Username123";
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

            String TestData = "xyz";

            ACustomer.CustomerFullName = TestData;

            Assert.AreEqual(ACustomer.CustomerFullName, TestData);
        }

        [TestMethod]
        public void CustomerPhoneNumberPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            int TestData = 12345;

            ACustomer.CustomerPhoneNumber = TestData;

            Assert.AreEqual(ACustomer.CustomerPhoneNumber, TestData);
        }

        [TestMethod]
        public void CustomerEmailIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "xyz@gmail.com";

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
        public void CityPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "Some City";

            ACustomer.City = TestData;

            Assert.AreEqual(ACustomer.City, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "LE2 4AB";

            ACustomer.PostCode = TestData;

            Assert.AreEqual(ACustomer.PostCode, TestData);
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

    }
}
