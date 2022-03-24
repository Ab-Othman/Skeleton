
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
            //create an instance of the data connection
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

        public string Valid(string customerFullName, string customerPhoneNumber, string customerEmailId, string customerAccountCreated, string customerAddress)
        {
            String Error = "";
            DateTime DateTemp;
            //customer full name
            //if the customer full name is blank
            if (customerFullName.Length == 0)
            {
                //record the error
                Error = Error + "The Customer Full Name may not be blank : ";
            }
            
            //if Customer full name is greater than 30
            if (customerFullName.Length > 30)
            {
                Error = Error + "The Customer Full Name must be less than 30 characters : ";
            }

            //customer phone number
            //if the customer phone number is blank
            if(customerPhoneNumber.Length == 0)
            {

                //record the error
                Error = Error + "The Customer Phone Number may not be blank :";
            }

            //if the customer phone number is greater than 16
            if(customerPhoneNumber.Length > 16)
            {

                //record the error
                Error = Error + "The Customer Phone Number must be less than 16 characters : ";
            }

            //customer email id
            //if the customer phone number is blank
            if (customerEmailId.Length == 0)
            {

                //record the error
                Error = Error + "The Customer EmailId may not be blank :";
            }
            
            //if the customer phone number is greater than 16
            if (customerEmailId.Length > 30)
            {

                //record the error
                Error = Error + "The Cusstomer Phone Number must be less than 30 characters : ";
            }

            //copy the  customer account created value to the DateTemp variable
            try
            {
                DateTemp = Convert.ToDateTime(customerAccountCreated);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                //check to see if the date is greates than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }


            //customer address
            //if the customer phone number is blank
            if (customerAddress.Length == 0)
            {

                //record the error
                Error = Error + "The Customer Address may not be blank :";
            }

            //if the customer phone number is greater than 16
            if (customerAddress.Length > 50)
            {

                //record the error
                Error = Error + "The Customer Address must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}