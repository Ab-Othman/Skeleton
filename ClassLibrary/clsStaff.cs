using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    public class clsStaff
    {
        // private member variable Manager
        private Boolean mManagement;
        // public property for Manager
        public Boolean Management
        {
            get
            {
                //return the private data
                return mManagement;
            }
            set
            {
                //set the private data
                mManagement = value;
            }
        }

        // private member variable Staff Id
        private Int32 mStaffId;
        // public property for Staff Id
        public int StaffId
        {
            get
            {
                //return the private data
                return mStaffId;
            }
            set
            {
                //set the value of the private data member
                mStaffId = value;
            }
        }

        // private member variable staff first name
        private string mStaffFirstName;
        // public property for Staff first name
        public string StaffFirstName
        {
            get
            {
                //return the private data
                return mStaffFirstName;
            }
            set
            {
                //set the value of the private data member
                mStaffFirstName = value;
            }
        }

        // private member variable last name
        private string mStaffLastName;
        // public property for Staff Id
        public string StaffLastName
        {
            get
            {
                //return the private data
                return mStaffLastName;
            }
            set
            {
                //set the value of the private data member
                mStaffLastName = value;
            }
        }

        // private member variable staff Email
        private string mStaffEmail;
        // public property for Staff Email
        public string StaffEmail
        {
            get
            {
                //return the private data
                return mStaffEmail;
            }
            set
            {
                //set the value of the private data member
                mStaffEmail = value;
            }
        }

        // private member variable staff phone number
        private Int32 mStaffPhoneNumber;
        // public property for Staff Phone Number
        public Int32 StaffPhoneNumber
        {
            get
            {
                //return the private data
                return mStaffPhoneNumber;
            }
            set
            {
                //set the value of the private data member
                mStaffPhoneNumber = value;
            }
        }

        // private member variable staff weekly contracterd hours
        private Int32 mStaffWeeklyContractedHours;
        // public property for Staff weekly contracted hours
        public Int32 StaffWeeklyContractedHours
        {
            get
            {
                //return the private data
                return mStaffWeeklyContractedHours;
            }
            set
            {
                //set the value of the private data member
                mStaffWeeklyContractedHours = value;
            }
        }
        // private member variable  test staff found
        private Int32 mTestStaffId;
        // public property for test staff found
        public Int32 TestStaffId
        {
            get
            {
                //return the private data
                return mTestStaffId;
            }
            set
            {
                //set the value of the private data member
                mStaffWeeklyContractedHours = value;
            }
        }

        public int StaffWeekyContractedHours { get; set; }




        public bool Find(int StaffId)
        {
            //set the private data members to the test data value
            mManagement = true;
            mStaffId = 4;
            mStaffFirstName = "Teri";
            mStaffLastName = "Potter";
            mStaffEmail = "Harry@gmail.com";
            mStaffPhoneNumber = 0740676665;
            mStaffWeeklyContractedHours = 90;
            //always return true
            return true;
        }
    }
}








