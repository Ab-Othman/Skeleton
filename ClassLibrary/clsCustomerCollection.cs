using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        //private data member thiAddress
        clsCustomer mThisCustomer = new clsCustomer();

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

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {//set the private data
                mThisCustomer = value;
            }
        }

        //adds the new recoed to the database based on the values of thisCustomer
        public int Add()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stores procedure
            DB.AddParameter("@CustomerFullName", mThisCustomer.CustomerFullName);
            DB.AddParameter("@CustomerPhoneNumber", mThisCustomer.CustomerPhoneNumber);
            DB.AddParameter("@CustomerEmailId", mThisCustomer.CustomerEmailId);
            DB.AddParameter("@CustomerAccountCreated", mThisCustomer.CustomerAccountCreated);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@SubscribedToReceiveMail", mThisCustomer.SubscribedToReceiveMail);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerUserId", mThisCustomer.CustomerUserId);
            DB.AddParameter("@CustomerFullName", mThisCustomer.CustomerFullName);
            DB.AddParameter("@CustomerPhoneNumber", mThisCustomer.CustomerPhoneNumber);
            DB.AddParameter("@CustomerEmailId", mThisCustomer.CustomerEmailId);
            DB.AddParameter("@CustomerAccountCreated", mThisCustomer.CustomerAccountCreated);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@SubscribedToReceiveMail", mThisCustomer.SubscribedToReceiveMail);

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed by thisCustomer
            //connect  to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedures
            DB.AddParameter("@CustomerUserId", mThisCustomer.CustomerUserId);

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }
    }
}