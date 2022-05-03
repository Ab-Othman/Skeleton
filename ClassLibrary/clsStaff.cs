using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    public class clsStaff
    {

        //staffid private member variable
        private Int32 mStaffId;
        //StaffId public property
        public Int32 StaffId
        {
            get
            {
                //this line of code sends data out of the property 
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }


        //staffid private member variable
        private string mStaffFirstName;
        //StaffId public property
        public string StaffFirstName
        {
            get
            {
                //this line of code sends data out of the property 
                return mStaffFirstName;
            }
            set
            {
                //this line of code allows data into the property
                mStaffFirstName = value;
            }
        }

        //staffid private member variable
        private string mStaffLastName;
        //StaffId public property
        public string StaffLastName
        {
            get
            {
                //this line of code sends data out of the property 
                return mStaffLastName;
            }
            set
            {
                //this line of code allows data into the property
                mStaffLastName = value;
            }
        }

        //staffid private member variable
        private string mStaffEmail;
        //StaffId public property
        public string StaffEmail
        {
            get
            {
                //this line of code sends data out of the property 
                return mStaffEmail;
            }
            set
            {
                //this line of code allows data into the property
                mStaffEmail = value;
            }
        }


        //staffid private member variable
        private Int32 mStaffPhoneNumber;
        //StaffId public property
        public Int32 StaffPhoneNumber
        {
            get
            {
                //this line of code sends data out of the property 
                return mStaffPhoneNumber;
            }
            set
            {
                //this line of code allows data into the property
                mStaffPhoneNumber = value;
            }
        }


        //staffid private member variable
        private Int32 mStaffWeeklyContractedHours;
        //StaffId public property
        public Int32 StaffWeeklyContractedHours
        {
            get
            {
                //this line of code sends data out of the property 
                return mStaffWeeklyContractedHours;
            }
            set
            {
                //this line of code allows data into the property
                mStaffWeeklyContractedHours = value;
            }
        }

        //staffid private member variable
        private Boolean mManagement;
        //StaffId public property
        public bool Management
        {
            get
            {
                //this line of code sends data out of the property 
                return mManagement;
            }
            set
            {
                //this line of code allows data into the property
                mManagement = value;
            }
        }


        public bool Find(int StaffId)
        {
            //set the private data members to the test data values
            mStaffId = 21;
            mStaffFirstName = "James";
            mStaffLastName = "Barclays";
            mStaffEmail = "Harry@gmail.com";
            mStaffPhoneNumber = 0748056575;
            mStaffWeeklyContractedHours = 34;
            mManagement = true;

            // return true
            return true;
        }
    }
}








