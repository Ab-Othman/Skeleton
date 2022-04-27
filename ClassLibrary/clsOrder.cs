using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderNo;
        private Int32 mCustomerUserId;
        private DateTime mOrderDate;
        private string mShippingAddress;
        private string mPaymentMethod;
        private bool mPaymentReceived;
        private string mOrderStatus;

        public Int32 OrderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }
        public Int32 CustomerUserId
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
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        public String ShippingAddress
        {
            get
            {
                return mShippingAddress;
            }
            set
            {
                mShippingAddress = value;
            }
        }
        public String PaymentMethod
        {
            get
            {
                return mPaymentMethod;
            }
            set
            {
                mPaymentMethod = value;
            }
        }
        public Boolean PaymentReceived
        {
            get
            {
                return mPaymentReceived;
            }
            set
            {
                mPaymentReceived = value;
            }
        }
        public String OrderStatus
        {
            get
            {
                return mOrderStatus;
            }
            set
            {
                mOrderStatus = value;
            }
        }

        public String ListBoxData
        {
            get
            {
                return mOrderNo + " | " + mOrderDate + " | " + mOrderStatus;
            }
        }

        public bool Find(int OrderNo)
        {

            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order no to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //if one record is founnd (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomerUserId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerUserId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                mPaymentReceived = Convert.ToBoolean(DB.DataTable.Rows[0]["PaymentReceived"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string orderDate, string shippingAddress, string paymentMethod, string orderStatus)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temp variable to store data values
            DateTime DateTemp;
         
            //if paymentMethod is blank
            if (paymentMethod.Length == 0)
            {
                //record the error
                Error = Error + "The paymentMethod may not be blank : ";
            }
            //if the paymentMethod is greater than 10 characters
            if (paymentMethod.Length > 10)
            {
                //record the error 
                Error = Error + "The paymentMethod must be less than 10 charcacters : ";
            }
            //is the orderStatus blank
            if (orderStatus.Length == 0)
            {
                //record the error
                Error = Error + "The orderStatus may not be blank : ";
            }
            //if the orderStatus is too long
            if (orderStatus.Length == 20)
            {
                //record the error
                Error = Error + "The orderStatus must be less than 20 Characters : ";
            }
            //is the shippingAddress blank
            if (shippingAddress.Length == 0)
            {
                //record the error
                Error = Error + "The ShippingAddress may not be blank : ";
            }
            //if the shipping from address is too long
            if (shippingAddress.Length == 50)
            {
                //record the error
                Error = Error + "The shippingAddress must be less than 50 Characters : ";
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);
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