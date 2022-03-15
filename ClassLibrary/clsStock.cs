using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the stock no property
        private Int32 mPhoneNo;
        //Address No public property
        public Int32 PhoneNo
        {
            get
            {
                //this line of code sends the data out of the property
                return mPhoneNo;
            }
            set
            {
                //this line of code allows data into the property
                mPhoneNo = value;
            }
        }

        private string mPhoneDescription;
        public string PhoneDescription
        {
            get
            {
                return mPhoneDescription;
            }
            set
            {
                mPhoneDescription = value;
            }
        }
        private string mPhoneColour;
        public string PhoneColour
        {
            get
            {

                //return the private data
                return mPhoneColour;
            }
            set
            {
                //set the private data
                mPhoneColour = value;
            }
        }
        private DateTime mDateReleased;
        public DateTime DateReleased
        {
            get
            {
                //return the private data 
                return mDateReleased;
            }
            set
            {
                //set the private data
                mDateReleased = value;
            }
        }
        private double mPrice;
        public double Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }
        private Boolean mAvailability;
        public Boolean Availability
        {
            get
            {
                //return the private data
                return mAvailability;
            }
            set
            {
                //set the private data
                mAvailability = value;
            }
        }

        public bool Find(int phoneNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the phone no to search for
            DB.AddParameter("@PhoneNo", PhoneNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblStock_FilterByPhoneNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mPhoneNo = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNo"]);
                mPhoneDescription = Convert.ToString(DB.DataTable.Rows[0]["PhoneDescription"]);
                mPhoneColour = Convert.ToString(DB.DataTable.Rows[0]["PhoneColour"]);
                mDateReleased = Convert.ToDateTime(DB.DataTable.Rows[0]["DateReleased"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }
    }
}