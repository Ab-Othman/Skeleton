using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.Management = true;
            TestItem.StaffId = 1;
            TestItem.StaffFirstName = "James";
            TestItem.StaffLastName = "Barclays";
            TestItem.StaffEmail = "Harry@gmail.com";
            TestItem.StaffPhoneNumber = 988872873;
            TestItem.StaffWeeklyContractedHours = 25;
            TestItem.StaffStartDate = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }


        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.Management = true;
            TestStaff.StaffId = 1;
            TestStaff.StaffFirstName = "James";
            TestStaff.StaffLastName = "Barclays";
            TestStaff.StaffEmail = "Harry@gmail.com";
            TestStaff.StaffPhoneNumber = 988872873;
            TestStaff.StaffWeeklyContractedHours = 25;
            TestStaff.StaffStartDate = DateTime.Now.Date;

            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.Management = true;
            TestItem.StaffId = 1;
            TestItem.StaffFirstName = "James";
            TestItem.StaffLastName = "Barclays";
            TestItem.StaffEmail = "Harry@gmail.com";
            TestItem.StaffPhoneNumber = 988872873;
            TestItem.StaffWeeklyContractedHours = 25;
            TestItem.StaffStartDate = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Management = true;
            TestItem.StaffId = 1;
            TestItem.StaffFirstName = "James";
            TestItem.StaffLastName = "Barclays";
            TestItem.StaffEmail = "Harry@gmail.com";
            TestItem.StaffPhoneNumber = 988872873;
            TestItem.StaffWeeklyContractedHours = 25;
            TestItem.StaffStartDate = DateTime.Now.Date;

            AllStaff.ThisStaff = TestItem;
            TestItem.StaffId = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Management = true;
            TestItem.StaffId = 1;
            TestItem.StaffFirstName = "James";
            TestItem.StaffLastName = "Barclays";
            TestItem.StaffEmail = "Harry@gmail.com";
            TestItem.StaffPhoneNumber = 988872873;
            TestItem.StaffWeeklyContractedHours = 25;
            TestItem.StaffStartDate = DateTime.Now.Date;

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.Management = false;
            TestItem.StaffId = 2;
            TestItem.StaffFirstName = "Jam";
            TestItem.StaffLastName = "hello";
            TestItem.StaffEmail = "Harrystyles@gmail.com";
            TestItem.StaffPhoneNumber = 988872823;
            TestItem.StaffWeeklyContractedHours = 23;
            TestItem.StaffStartDate = DateTime.Now.Date;

            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Management = true;
            TestItem.StaffId = 1;
            TestItem.StaffFirstName = "James";
            TestItem.StaffLastName = "Barclays";
            TestItem.StaffEmail = "Harry@gmail.com";
            TestItem.StaffPhoneNumber = 988872873;
            TestItem.StaffWeeklyContractedHours = 25;
            TestItem.StaffStartDate = DateTime.Now.Date;

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();

            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByStaffLastNameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByStaffLastName("");
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffLastNameNoneFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByStaffLastName("jeff");
            Assert.AreEqual(0, FilteredStaff.Count);
        }


        [TestMethod]
        public void ReportByStaffLastNameTestDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;
            FilteredStaff.ReportByStaffLastName("Jeff");
            if (FilteredStaff.Count == 2)
            {
                if (FilteredStaff.StaffList[0].StaffId != 36)
                {
                    OK = false;
                }
                if (FilteredStaff.StaffList[1].StaffId != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}