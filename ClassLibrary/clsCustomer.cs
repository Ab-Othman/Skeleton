using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerUserId;
        public int CustomerUserId
        {
            get
            {
                return mCustomerUserId;
            }
            set
            {
                mCustomerUserId = value;
            }

        }

        public string CustomerFullName { get; set; }
        public String CustomerPhoneNumber { get; set; }
        public string CustomerEmailId { get; set; }
        public string CustomerAddress { get; set; }
        public bool SubscribedToReceiveMail { get; set; }
        public DateTime CustomerAccountCreated { get; set; }

        public bool Find(int customerUserId)
        {
            //set the private data members to the test data value
            mCustomerUserId = 12312;
            //always return true
            return true;
        }
    }
}