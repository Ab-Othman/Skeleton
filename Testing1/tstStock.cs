using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assisgn property
            int TestData = 154;
            //assign the data to the property
            AnStock.PhoneNo = TestData;
            // test to see that two values are the same
            Assert.AreEqual(AnStock.PhoneNo, TestData);
        }

        [TestMethod]

        public void PhoneDescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign property
            string TestData = "Newest Iphone we have";
            //assign the data to the property
            AnStock.PhoneDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.PhoneDescription, TestData);
        }

        [TestMethod]

        public void PhoneColourPropertyOK()
        {
            //create and instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign property
            string TestData = "Yellow";
            //assign the data to the property
            AnStock.PhoneColour = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnStock.PhoneColour, TestData);
        }

        [TestMethod]

        public void DateReleasedPropertyOK()
        {
            //create and instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test datat to assign property
            DateTime TestData = DateTime.Today.Date;
            //assign the data to the property
            AnStock.DateReleased = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.DateReleased, TestData);
        }

        [TestMethod]

        public void PricePropertyOk()
        {
            //create and instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            double TestData = 499.99;
            //assign the data to the property
            AnStock.Price = TestData;
            //tests to see that two vlaues are the same
            Assert.AreEqual(AnStock.Price, TestData);

        }

        [TestMethod]

        public void AvailabilityPropertyOk()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            AnStock.Availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Availability, TestData);
        }
        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Int32 PhoneNo = 1;
            //invoke the method
            Found = AnStock.Find(PhoneNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]

        public void TestPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PhoneNo = 1;
            //invoke the method
            Found = AnStock.Find(PhoneNo);
            //check the stock no
            if (AnStock.PhoneNo != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestPhoneDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PhoneNo = 1;
            //invoke the method
            Found = AnStock.Find(PhoneNo);
            //check the property
            if (AnStock.PhoneDescription != "Iphone 13 Max")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }



        [TestMethod]

        public void TestDateAdded()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PhoneNo = 1;
            //invoke the method
            Found = AnStock.Find(PhoneNo);
            //check the property
            if (AnStock.DateReleased != Convert.ToDateTime("24/10/2021"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }



        [TestMethod]

        public void TestPrice()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PhoneNo = 1;
            //invoke the method
            Found = AnStock.Find(PhoneNo);
            //check the property
            if (AnStock.Price != Convert.ToDouble(500))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestAvailability()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PhoneNo = 1;
            //invoke the method
            Found = AnStock.Find(PhoneNo);
            //check the property
            if (AnStock.Availability != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneColour()
        {
            //create an instance of the clas we want to create
            clsStock AnStock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PhoneNo = 1;
            Found = AnStock.Find(PhoneNo);
            //check the property
            if (AnStock.PhoneColour != "Red")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }




    }
