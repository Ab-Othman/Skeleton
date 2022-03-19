using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerUserId;
        public Int32 CustomerUserId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerUserId;
            }
            set
            {  
                //this line of code allows data into the property
                mCustomerUserId = value;
            }

        }


        private string mCustomerFullName;
        public string CustomerFullName
        {
            get
            {
                return mCustomerFullName;
            }
            set
            {
                mCustomerFullName = value;
            }
        }

        private string mCustomerPhoneNumber;
        public String CustomerPhoneNumber
        {
            get 
            {
                return mCustomerPhoneNumber;
            }
            set 
            {
                mCustomerPhoneNumber = value;
            }
        }

        private string mCustomerEmailId;
        public string CustomerEmailId 
        {
            get
            {
                return mCustomerEmailId;
            }
            set 
            { 
                mCustomerEmailId = value; 
            }
        }

        public DateTime mCustomerAccountCreated;
        public DateTime CustomerAccountCreated
        {
            get
            {
                return mCustomerAccountCreated;
            }
            set
            {
                mCustomerAccountCreated = value;
            }
        }

        private string mCustomerAddress;
        public string CustomerAddress
        {
            get
            {
                return mCustomerAddress;
            }
            set
            {
                mCustomerAddress = value;
            }
        }

            private bool mSubscribedToReceiveMail;
        public bool SubscribedToReceiveMail
        {
            get
            {
                return mSubscribedToReceiveMail;
            }
            set
            {
                mSubscribedToReceiveMail = value;
            }
        }
        

        public bool Find(int CustomerUserId)
        {
            //set the private data members to the test data value
            mCustomerUserId = 12312;

            mCustomerFullName = "xyz";

            mCustomerPhoneNumber = "654321789";

            mCustomerEmailId = "xyz@gmail.com";

            mCustomerAccountCreated = Convert.ToDateTime("05/05/2011");

            mCustomerAddress = "Leicester City, LE3 5TE";

            mSubscribedToReceiveMail = true;
            //always return true
            return true;
        }
    }
}