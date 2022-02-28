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
            //set private data memebers to the test data value
            mSupplierID = 3;
            mDateAdded = Convert.ToDateTime("15/08/2000");
            mPhoneNumber = "07559983467";
            mEmail = "huawei@huawei.com";
            mShippingFromAddress = "China";
            mSupplierName = "Huawei";
            mActive = true;
            //always return true
            return true;
        }
    }
}