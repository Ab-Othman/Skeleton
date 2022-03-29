using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public List<clsCustomer> CustomerList
        {
            get
            {
                //retun the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {//we shall worry abou this later;
            }
        }

        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;

            //var to store the record count
            Int32 RecordCount = 0;

            //object for data connection
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomer_SelectAll");

            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer ACustomer = new clsCustomer();

                ACustomer.CustomerUserId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerUserId"]);
                ACustomer.CustomerFullName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFullName"]);
                ACustomer.CustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhoneNumber"]);
                ACustomer.CustomerEmailId = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmailId"]);
                ACustomer.CustomerAccountCreated = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerAccountCreated"]);
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                ACustomer.SubscribedToReceiveMail = Convert.ToBoolean(DB.DataTable.Rows[Index]["SubscribedToReceiveMail"]);

                mCustomerList.Add(ACustomer);

                //point at next record
                Index++;
            }

        }

        public object ThisCustomer { get; set; }
    }
}