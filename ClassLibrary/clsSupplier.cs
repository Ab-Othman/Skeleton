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

        public bool Find(int stringID)
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
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mShippingFromAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingFromAddress"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
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
    }
}
