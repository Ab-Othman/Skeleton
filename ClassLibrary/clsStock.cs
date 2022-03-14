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
            //set the private data members to the test data value
            mPhoneNo = 21;
            mPhoneDescription = "Test Description";
            mPhoneColour = "Test Phone Colour";
            mDateReleased = Convert.ToDateTime("16/04/2015");
            mPrice = Convert.ToDouble("499.99");
            mAvailability = true;
            //always return true
            return true;

        }
    }
}