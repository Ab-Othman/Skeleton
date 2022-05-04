using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        // good test data 
        // create some test data to pass the method
        string StaffFirstName = "James";
        string StaffLastName = "Barclays";
        string StaffEmail = "Harry@gmail.com";
        string StaffPhoneNumber = "988872873";
        string StaffWeeklyContractedHours = "25";
        string StaffStartDate = DateTime.Now.Date.ToString();


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
        public void StaffStartDatePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some data
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.StaffStartDate = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.StaffStartDate, TestData);
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

        [TestMethod]
        public void TestStaffStartDateFound()
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
            if (AnStaff.StaffStartDate != Convert.ToDateTime(12 / 09 / 2000))
            {
                OK = false;
            }
            //test to see that results correct
            Assert.IsTrue(OK);
        }


        // [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        // [TestMethod]
        public void StaffFirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffFirstName = "";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        // [TestMethod]
        public void StaffFirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffFirstName = "a";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
        }

        // [TestMethod]
        public void StaffFirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffFirstName = "aa";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        // [TestMethod]
        public void StaffFirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffFirstName = "aaaaa";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        // [TestMethod]
        public void StaffFirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffFirstName = "aaaaaa";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
        }

        // [TestMethod]
        public void StaffFirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            StaffEmail = StaffFirstName.PadRight(25, 'a');
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
        }

        // [TestMethod]
        public void StaffFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffFirstName = "aaaaaaa";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }


        // [TestMethod]
        public void StaffFirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(500, 'a');
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        // [TestMethod]
        public void StaffStartDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string StaffStartDate = TestDate.ToString();
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        // [TestMethod]
        public void StaffStartDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string StaffStartDate = TestDate.ToString();
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        // [TestMethod]
        public void StaffStartDateMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string StaffStartDate = TestDate.ToString();
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }


        // [TestMethod]
        public void StaffStartDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string StaffStartDate = TestDate.ToString();
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        // [TestMethod]
        public void StaffStartDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(100);
            string StaffStartDate = TestDate.ToString();
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        // [TestMethod]
        public void StaffStartDateInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffStartDate = "This is not the date: ";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        // [TestMethod]
        public void StaffLastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffLastName = "";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        // [TestMethod]
        public void StaffLastNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffLastName = "a";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
        }

        // [TestMethod]
        public void StaffLastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffLastName = "aa";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        // [TestMethod]
        public void StaffLastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffLastName = "aaaaa";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        // [TestMethod]
        public void StaffLastNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffLastName = "aaaaaa";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
        }

        // [TestMethod]
        public void StaffLastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            StaffEmail = StaffLastName.PadRight(25, 'a');
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
        }

        // [TestMethod]
        public void StaffLastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffLastName = "aaaaaaa";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }


        // [TestMethod]
        public void StaffLastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffLastName = "";
            StaffLastName = StaffFirstName.PadRight(500, 'a');
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        // [TestMethod]
        public void StaffEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        // [TestMethod]
        public void StaffEmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "a";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
        }

        // [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "aa";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        // [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "aaaaa";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        // [TestMethod]
        public void StaffEmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "aaaaaa";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
        }

        // [TestMethod]
        public void StaffEmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(25, 'a');
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
        }

        // [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "aaaaaaa";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }


        // [TestMethod]
        public void StaffEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffLastName = "";
            StaffEmail = StaffEmail.PadRight(500, 'a');
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");

        }
            //[TestMethod]
            public void StaffPhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffPhoneNumber = "";
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        // [TestMethod]
        public void StaffPhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            int StaffPhoneNumber = 914365496;
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours, StaffStartDate);
        }

        // [TestMethod]
        public void StaffPhoneNumberPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            int StaffPhoneNumber = Convert.ToInt32(91436549676);
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        // [TestMethod]
        public void StaffPhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            int StaffPhoneNumber = 914365496;
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        // [TestMethod]
        public void StaffPhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            int StaffPhoneNumber = 914365496;
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours, StaffStartDate);
        }

        // [TestMethod]
        public void StaffPhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            int StaffPhoneNumber = 9143;
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours, StaffStartDate);
        }

        // [TestMethod]
        public void StaffPhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            int StaffPhoneNumber = Convert.ToInt32(91436549676);
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }


        // [TestMethod]
        public void StaffPhoneNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffPhoneNumber = "";
            StaffPhoneNumber = StaffFirstName.PadRight(500,'9');
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        //[TestMethod]
        public void StaffWeeklyContractedHoursMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            int StaffWeeklyContractedHours = Convert.ToInt32(0);
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours.ToString(), StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        // [TestMethod]
        public void StaffWeeklyContractedHoursMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            int StaffWeeklyContractedHours = 0;
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours.ToString(), StaffStartDate);
        }

        // [TestMethod]
        public void StaffWeeklyContractedHoursMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            int StaffWeeklyContractedHours = Convert.ToInt32(1);
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours.ToString(), StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        // [TestMethod]
        public void StaffWeeklyContractedHoursMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            int StaffWeeklyContractedHours = 167;
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours.ToString(), StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        // [TestMethod]
        public void StaffWeeklyContractedHoursMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            int StaffWeeklyContractedHours = 168;
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours.ToString(), StaffStartDate);
        }

        // [TestMethod]
        public void StaffWeeklyContractedHoursMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            int StaffWeeklyContractedHours = 84;
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours.ToString(), StaffStartDate);
        }

        // [TestMethod]
        public void StaffWeeklyContractedHoursMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            int StaffWeeklyContractedHours = Convert.ToInt32(169);
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber.ToString(), StaffWeeklyContractedHours.ToString(), StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }


        // [TestMethod]
        public void StaffWeeklyContractedHoursExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffWeeklyContractedHours = "";
            StaffWeeklyContractedHours = StaffWeeklyContractedHours.PadRight(500, '9');
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

    }
}
