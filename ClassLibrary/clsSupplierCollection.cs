using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        //private data member for list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        private clsSupplier mThisSupplier; 

        public clsSupplierCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure 
            DB.Execute("sproc_tblSupplier_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        
        public List<clsSupplier> SupplierList
        {
            get
            {
                //return private data
                return mSupplierList;
            }
            set
            {
                //set private data
                mSupplierList = value;
            }
        }
     
        public int Count
        {
            get
            {
                //return count of list
                return mSupplierList.Count;
            }
            set
            {
                //worry later 
            }
        }
        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisSupplier
            //set the primary key value of the new record
            mThisSupplier.SupplierID = 3;
            //return the primary key of the new record
            return mThisSupplier.SupplierID;
            //adds a new record to the database based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure 
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.AddParameter("@Email", mThisSupplier.Email);
            DB.AddParameter("@PhoneNumber", mThisSupplier.PhoneNumber);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ShippingFromAddress", mThisSupplier.ShippingFromAddress);
            DB.AddParameter("@DateAdded", mThisSupplier.DateAdded);
            DB.AddParameter("@Active", mThisSupplier.Active);
            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisSupplier
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.AddParameter("@Email", mThisSupplier.Email);
            DB.AddParameter("@PhoneNumber", mThisSupplier.PhoneNumber);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ShippingFromAddress", mThisSupplier.ShippingFromAddress);
            DB.AddParameter("@DateAdded", mThisSupplier.DateAdded);
            DB.AddParameter("@Active", mThisSupplier.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisSupplier
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set parameteres for stored procedure
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            //execute stored procedure
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportBySupplierName(string SupplierName)
        {
            //filters the records based on a full or partial name    
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the SupplierName parameter to the database
            DB.AddParameter("@SupplierName", SupplierName);
            //execute the stored procedure 
            DB.Execute("sproc_tblSupplier_FilterBySupplierName");
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
            mSupplierList = new List<clsSupplier>();
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank supplier 
                clsSupplier ASupplier = new clsSupplier();
                //read in the fields from the current record 
                ASupplier.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ASupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                ASupplier.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ASupplier.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                ASupplier.ShippingFromAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingFromAddress"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mSupplierList.Add(ASupplier);
                //point at the next record
                Index++;
            }
        }
    }
      
        
}