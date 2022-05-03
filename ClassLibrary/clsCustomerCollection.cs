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

        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");

            //populate the array list wih the data table
            PopulateArray(DB);

        }

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

        public void ReportByCustomerFullName(string CustomerFullName)
        {
            //filters the records based on a full or partial post code
            //connect tothe database
            clsDataConnection DB = new clsDataConnection();

            //send the CustomerFullName parameter to the database
            DB.AddParameter("@CustomerFullName", CustomerFullName);

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerFullName");

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

            //get the countof records
            RecordCount = DB.Count;

            //clear the private array list
            mCustomerList = new List<clsCustomer>();

            //while there are records to process
            while (Index < RecordCount )
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();

                //read int the field from the current record
                ACustomer.SubscribedToReceiveMail = Convert.ToBoolean(DB.DataTable.Rows[Index]["SubscribedToReceiveMail"]);
                ACustomer.CustomerUserId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerUserId"]);
                ACustomer.CustomerFullName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFullName"]);
                ACustomer.CustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhoneNumber"]);
                ACustomer.CustomerEmailId = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmailId"]);
                ACustomer.CustomerAccountCreated = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerAccountCreated"]);
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);

                //add the record to the private data member
                mCustomerList.Add(ACustomer);

                //point at the next record
                Index++;
            }
        }
    }
}