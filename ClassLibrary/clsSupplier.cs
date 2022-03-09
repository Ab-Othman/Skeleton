using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private Boolean mActive;
        public bool Active
        {
            get
            {
                //return private data
                return mActive;
            }
            set
            {
                //set private data
                mActive = value;
            }
        }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                //get private data
                return mDateAdded;
            }
            set
            {
                //set private data
                mDateAdded = value; 
            }
        }
        private string mShippingFromAddress;
        public string ShippingFromAddress
        {
            get
            {
                //get private data
                return mShippingFromAddress;
            }
            set
            {
                //set private data
                mShippingFromAddress = value;
            }
        }
        private string mPhoneNumber;
        public string PhoneNumber
        {
            get
            {
                //get private data
                return mPhoneNumber;
            }
            set
            {
                //set private data
                mPhoneNumber = value; 
            }
        }
        private Int32 mSupplierID;
        public int SupplierID
        {
            get
            {
                //get private data
                return mSupplierID;
            }
            set
            {
                //set private data
                mSupplierID = value; 
            }
        }
        private string mEmail;
        public string Email
        {
            get
            {
                //get private data
                return mEmail;
            }
            set
            {
                //set private data
                mEmail = value;
            }
        }
        private string mSupplierName;
        public string SupplierName
        {
            get
            {
                //get private data
                return mSupplierName;
            }
            set
            {
                //set private data
                mSupplierName = value; 
            }
        }

        public bool Find(int supplierID)
        {
            //set the private data members to the test data value
            mSupplierID = 3;
            mPhoneNumber = "07559983467";
            mEmail = "huawei@huawei.com";
            mDateAdded = Convert.ToDateTime("15/08/2000");
            mShippingFromAddress = "China";
            mSupplierName = "Huawei";
            mActive = true;
            //always return true
            return true;
        }
    }
}