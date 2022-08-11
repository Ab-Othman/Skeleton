using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass to the method
        string PhoneDescription = "Iphone 14";
        string PhoneColour = "Black";
        string DateReleased = DateTime.Now.Date.ToString();
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string  variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneDescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneDescription = ""; //this should trigger an error
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneDescriptionMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneDescription = "a"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneDescriptionMinPlusOne()

        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneDescription = "aa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string PhoneDescription = "aaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneDescriptionMax()
        {
            //create and instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneDescription = "aaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneDescriptionMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneDescription = "aaaaaaaaaa";//this should be ok
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PhoneDescriptionMaxPlusOne()
        {
            //create and instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneDescription = "aaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneDescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variabe to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneDescription = "";
            PhoneDescription = PhoneDescription.PadRight(500, 'a');// this should fail
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateReleasedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateReleased = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateReleasedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string cariable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateReleased = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateReleasedMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateReleased = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateReleasedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string varaible to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to  whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string varaible
            string DateReleased = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateReleasedExtremeMax()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateReleased = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateReleasedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the DateReleased to a non date value
            string DateReleased = "this is not a date!";
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PhoneColourMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneColour = ""; //this should trigger an error
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneColourMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneColour = "a"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneColourMinPlusOne()

        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneColour = "aa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneColourMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string PhoneColour = "aaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneColourMax()
        {
            //create and instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneColour = "aaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneColourMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneColour = "aaaaaaaaaa";//this should be ok
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PhoneColourMaxPlusOne()
        {
            //create and instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneColour = "aaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneColourExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variabe to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneColour = "";
            PhoneColour = PhoneColour.PadRight(500, 'a');// this should fail
            //invoke the method
            Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
      
    }




}
