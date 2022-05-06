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

        public void Find(object staffId)
        {
            throw new NotImplementedException();
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


        //staffid private member variable
        private DateTime mStaffStartDate;
        //StaffId public property
        public DateTime StaffStartDate
        {
            get
            {
                //this line of code sends data out of the property 
                return mStaffStartDate;
            }
            set
            {
                //this line of code allows data into the property
                mStaffStartDate = value;
            }
        }


        public bool Find(int StaffId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", StaffId);
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            if (DB.Count == 1)
            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]);
                mStaffLastName = Convert.ToString(DB.DataTable.Rows[0]["StaffLastName"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["StaffPhoneNumber"]);
                mStaffWeeklyContractedHours = Convert.ToInt32(DB.DataTable.Rows[0]["StaffWeeklyContractedHours"]);
                mManagement = Convert.ToBoolean(DB.DataTable.Rows[0]["Management"]);
                mStaffStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffStartDate"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string staffFirstName, string staffLastName, string staffEmail, string staffPhoneNumber, string staffWeeklyContractedHours,string staffStartDate)
        {
            String Error = "";
            DateTime DateTemp;
            if (staffFirstName.Length == 0)
            {
                Error = Error + "Staff First Name may not be blank: ";

            }
            if (staffFirstName.Length > 50)
            {
                Error = Error + "Staff First Name must be less than 50 characters: ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(staffStartDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past: ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date: ";
            }

            if (staffLastName.Length == 0 )
            {
                Error = Error + "Staff Last Name cannot be blank: ";
            }
            if (staffLastName.Length>50)
            {
                Error = Error + "The Last name cannot be more than 50 characters: ";
            }

            if (staffEmail.Length == 0)
            {
                Error = Error + "Staff Phone number cannot be blank: ";
            }
            if (staffEmail.Length > 50)
            {
                Error = Error + "The Phone Number cannot be more than 50 characters: ";
            }

            if (staffPhoneNumber.Length == 0)
            {
                Error = Error + "Staff Phone Number cannot be blank: ";
            }
            if (staffPhoneNumber.Length > 9)
            {
                Error = Error + "The Last name cannot be more than 9 characters: ";
            }


            if (staffWeeklyContractedHours.Length == 0)
            {
                Error = Error + "Staff weekly contracted hours cannot be blank: ";
            }
            if (staffWeeklyContractedHours.Length > 169)
            {
                Error = Error + "The staff weekly contracted hours cannot be more than 168 hours: ";
            }
            return Error;
        }
    }
}








