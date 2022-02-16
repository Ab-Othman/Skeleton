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
            string TestData = "Red";
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
    }

}
