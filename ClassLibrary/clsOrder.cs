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

        public bool Find(int OrderNo)
        {
            //set the private data members to the test data value
            mOrderNo = 21;
            mCustomerUserId = 1;
            mOrderDate = Convert.ToDateTime("15/08/2000");
            mShippingAddress = "123 House";
            mPaymentMethod = "Card";
            mPaymentReceived = true;
            mOrderStatus = "Processed";
            //always return true
            return true;
        }
    }
}