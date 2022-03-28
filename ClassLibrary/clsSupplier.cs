using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        //private data member for supplier id property
        private Int32 mSupplierID;
        private DateTime mDateAdded;
        private Boolean mActive;
        private string mPhoneNumber;
        private string mEmail;
        private string mShippingFromAddress;
        private string mSupplierName;

        public bool Active
        {
            get
            {
                //return private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public string ShippingFromAddress
        {
            get
            {
                //set the private data
                return mShippingFromAddress;
            }
            set
            {
                //set the private data
                mShippingFromAddress = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                //return private data
                return mPhoneNumber;
            }
            set
            {
                //set private data
                mPhoneNumber = value;
            }
        }
        public Int32 SupplierID
        {
            get
            {
                return mSupplierID;
            }
            set
            {
                mSupplierID = value;
            }
        }
        public string Email
        {
            get
            {
                //return private data
                return mEmail;
            }
            set
            {
                //set private data
                mEmail = value;
            }
        }
        public string SupplierName
        {
            get
            {
                //return private data
                return mSupplierName;
            }
            set
            {
                //set private data
                mSupplierName = value;
            }

        }

        public bool Find(int SupplierID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@SupplierID", SupplierID);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            //if one record is found (there should be 1 or 0)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mShippingFromAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingFromAddress"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating problem
                return false;
            }



        }

        public string Valid(string phoneNumber, string email, string dateAdded, string shippingFromAddress, string supplierName)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temp variable to store data values
            DateTime DateTemp;
            //if PhoneNumber is blank
            if (phoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The Phone Number may not be blank : ";
            }
            //if the Phone Number is greater than 15 characters
            if (phoneNumber.Length > 15)
            {
                //record the error 
                Error = Error + "The Phone number must be less than 15 charcacters : ";
            }
            //is the email blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The Email may not be blank : ";
            }
            //if the email is too long
            if (email.Length == 50)
            {
                //record the error
                Error = Error + "The Email must be less than 50 Characters : ";
            }
            //is the ShippingFromAddress blank
            if (shippingFromAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Shipping From Address may not be blank : ";
            }
            //if the shipping from address is too long
            if (shippingFromAddress.Length == 50)
            {
                //record the error
                Error = Error + "The shipping From Address must be less than 50 Characters : ";
            }
            //is Supplier Name blank
            if(supplierName.Length == 0)
            {
                //record the error
                Error = Error + "The Supplier Name must not be blank : ";
            }
            //if the Supplier name is too long
            if (supplierName.Length == 51)
            {
                //record the error
                Error = Error + "The Supplier Name must be less than 50 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than todays date 
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
