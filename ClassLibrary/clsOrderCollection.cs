using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisOrder
        clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure 
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
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
            return DB.Execute("sproc_tblOrder_Insert");

        }

        public void Update()
        {
            //update an exisiting record based on values of ThisOrder
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@CustomerUserId", mThisOrder.CustomerUserId);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@PaymentReceived", mThisOrder.PaymentReceived);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByOrderStatus(string OrderStatus)
        {
            //filters the records based on the order status
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send the OrderStatus parameter to the databse
            DB.AddParameter("@OrderStatus", OrderStatus);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderStatus");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
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
    }
}