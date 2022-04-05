using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisOrder
        private clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure 
            DB.Execute("sproc_tblOrder_SelectAll");
            //get count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsOrder AnOrder = new clsOrder();
                //read in fields from current record
                AnOrder.PaymentReceived = Convert.ToBoolean(DB.DataTable.Rows[Index]["PaymentReceived"]);
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                AnOrder.CustomerUserId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerUserId"]);
                AnOrder.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                //add record to the private data member 
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

        public List<clsOrder> OrderList 
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set private data
                mOrderList = value;
            }
        }
        public clsOrder ThisOrder 
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
        public int Count 
        {
            get
            {
                //return count of list
                return mOrderList.Count;
            }
            set
            {
                //for later
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisOrder
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parametersfor the stored procedure
            DB.AddParameter("@CustomerUserId", mThisOrder.CustomerUserId);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@PaymentReceived", mThisOrder.PaymentReceived);
            //execute the stored procedure, returns the primary key value
            DB.Execute("sproc_tblOrder_Update");

        }
    }
}