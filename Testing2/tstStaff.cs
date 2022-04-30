using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsStaff Anstaff = new clsStaff();
            //test to see that exists
            Assert.IsNotNull(Anstaff);
        }

        [TestMethod]
        public void ManagerPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some data
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.Management = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.Management, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some data
            Int32 TestData = 4;
            //assign the data to the property
            AnStaff.StaffId = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }

        [TestMethod]
        public void StaffFirstNamePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some data
            string TestData = "Teri";
            //assign the data to the property
            AnStaff.StaffFirstName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.StaffFirstName, TestData);
        }

        [TestMethod]
        public void StaffLastNamePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some data
            string TestData = "Potter";
            //assign the data to the property
            AnStaff.StaffLastName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.StaffLastName, TestData);
        }

        [TestMethod]
        public void StaffEmailPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some data
            string TestData = "Harry@gmail.com";
            //assign the data to the property
            AnStaff.StaffEmail = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StaffPhoneNumberPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some data
            Int32 TestData = 0740676665;
            //assign the data to the property
            AnStaff.StaffPhoneNumber = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.StaffPhoneNumber, TestData);
        }

        [TestMethod]
        public void StaffWeeklyContractedHoursPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some data
            Int32 TestData = 90;
            //assign the data to the property
            AnStaff.StaffWeeklyContractedHours = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.StaffWeeklyContractedHours, TestData);


        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //creatre some test data to use with the method
            Int32 StaffFirstName = 21;
            //invoke the method
            Found = AnStaff.Find(StaffFirstName);
            //test to see if the results are true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestStaffIdNotFound()
        {
            //creates an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check to Staff first Name
            if (AnStaff.StaffId != 21)
            {
                OK = false;
            }
            //test to see hte result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //creates an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the results of hte search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TestStaffId = 21;
            //invoke the method
            Found = AnStaff.Find(TestStaffId);
            //check to Staff first Name
            if (AnStaff.TestStaffId != 4)
            {
                OK = false;
            }
            //test to see hte result is correct 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStaffFirstNameFound()
        {
            //creates an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the results of hte search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffFirstName = 21;
            //invoke the method
            Found = AnStaff.Find(StaffFirstName);
            //check to Staff first Name
            if (AnStaff.StaffFirstName != "Teri")
            {
                OK = false;
            }
            //test to see hte result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffLastNameFound()
        {
            //creates an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the results of hte search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffLastName = 21;
            //invoke the method
            Found = AnStaff.Find(StaffLastName);
            //check to Staff first Name
            if (AnStaff.StaffLastName != "Potter")
            {
                OK = false;
            }
            //test to see hte result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //creates an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the results of hte search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TestStaffEmail = 21;
            //invoke the method
            Found = AnStaff.Find(TestStaffEmail);
            //check to Staff first Name
            if (AnStaff.StaffEmail != "Harry@gmail.com")
            {
                OK = false;
            }
            //test to see hte result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPhoneNumberFound()
        {
            //creates an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the results of hte search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffPhoneNumber = 21;
            //invoke the method
            Found = AnStaff.Find(StaffPhoneNumber);
            //check to Staff first Name
            if (AnStaff.StaffPhoneNumber != 0740676665)
            {
                OK = false;
            }
            //test to see hte result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffWeekyContractedHoursFound()
        {
            //creates an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the results of hte search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffWeekyContractedHours = 21;
            //invoke the method
            Found = AnStaff.Find(StaffWeekyContractedHours);
            //check to Staff first Name
            if (AnStaff.StaffWeekyContractedHours != 90)
            {
                OK = false;
            }
            //test to see hte result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ManagementFound()
        {
            //creates an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the results of hte search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Management = 21;
            //invoke the method
            Found = AnStaff.Find(Management);
            //check to Staff first Name
            if (AnStaff.Management != true)
            {
                OK = false;
            }
            //test to see hte result is correct 
            Assert.IsTrue(OK);
        }
    }

}

