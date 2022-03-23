
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
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerUserId", CustomerUserId);

            DB.Execute("sproc_tblCustomer_FilterByCustomerUserId");

            if (DB.Count == 1)
            {
                mCustomerUserId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerUserId"]);
                mCustomerFullName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFullName"]);
                mCustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhoneNumber"]);
                mCustomerEmailId = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmailId"]);
                mCustomerAccountCreated = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerAccountCreated"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mSubscribedToReceiveMail = Convert.ToBoolean(DB.DataTable.Rows[0]["SubscribedToReceiveMail"]);

                return true;
            }
            else
            {
                return false;
            }              
        }
    }
}