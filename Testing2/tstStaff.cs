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
            //crate an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the results of the validation  
            Boolean Found = false;
            Int32 StaffId = 2;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //test to see if teh results is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if teh data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staffid = 2;
            //invokes the method
            Found = AnStaff.Find(Staffid);
            //check to Staff ID
            if (AnStaff.StaffId != 21)
            {
                OK = false;
            }
            //test to see that results correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffFirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if teh data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staffid = 2;
            //invokes the method
            Found = AnStaff.Find(Staffid);
            //check to Staff ID
            if (AnStaff.StaffFirstName != "James")
            {
                OK = false;
            }
            //test to see that results correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffLastNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if teh data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staffid = 2;
            //invokes the method
            Found = AnStaff.Find(Staffid);
            //check to Staff ID
            if (AnStaff.StaffLastName != "Barclays")
            {
                OK = false;
            }
            //test to see that results correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if teh data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staffid = 2;
            //invokes the method
            Found = AnStaff.Find(Staffid);
            //check to Staff ID
            if (AnStaff.StaffEmail != "Casey@gmail.com")
            {
                OK = false;
            }
            //test to see that results correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if teh data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staffid = 2;
            //invokes the method
            Found = AnStaff.Find(Staffid);
            //check to Staff ID
            if (AnStaff.StaffPhoneNumber != 988872873)
            {
                OK = false;
            }
            //test to see that results correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStaffWeeklyContractedHoursFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if teh data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staffid = 2;
            //invokes the method
            Found = AnStaff.Find(Staffid);
            //check to Staff ID
            if (AnStaff.StaffWeeklyContractedHours != 25)
            {
                OK = false;
            }
            //test to see that results correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestManagementFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if teh data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staffid = 1;
            //invokes the method
            Found = AnStaff.Find(Staffid);
            //check to Staff ID
            if (AnStaff.Management != true)
            {
                OK = false;
            }
            //test to see that results correct
            Assert.IsTrue(OK);
        }
    }
}

