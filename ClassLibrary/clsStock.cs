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

        public bool Find(int PhoneNo)
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

        public string Valid(string phoneDescription, string phoneColour, string dateReleased)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            if (phoneDescription.Length == 0)
            {
                //record the error
                Error = Error + "The Phone Description may not be blank : ";
            }
            //if the phone descrption is greater than 20 characters
            if(phoneDescription.Length > 20)
            {
                //record the error
                Error = Error + "The Phone Description must be less than 20 characters : ";
            }
            //is the PhoneColour blank
            if(phoneColour.Length == 0)
            {
                //record the error
                Error = Error + "The Phone Colour may not be blank : ";
            }
            //if the PhoneColour is too long
            if(phoneColour.Length > 20)
            {
                //record the error
                Error = Error + "The Phone Colour must be less than 20 characters : ";
            }
            try
            {
                //copy the dateReleased value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateReleased);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date 
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //return any error messages
            return Error;
        }

        
    }
}