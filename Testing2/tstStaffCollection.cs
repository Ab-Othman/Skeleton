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
    }
}