using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private data member thisStock
        clsStock mThisStock = new clsStock();

        
       
        public List<clsStock> StockList
        {
            get
            {
                    //return the private data
                    return mStockList;

            }
            set
        {
                    //set the private data
                    mStockList = value;
            }
        }

        //public property for count
        public int Count
        {
          
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //later
            }
        }

        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        //constructors for the class
        public clsStockCollection()
        { 
         
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);
           
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PhoneDescription", mThisStock.PhoneDescription);
            DB.AddParameter("@PhoneColour", mThisStock.PhoneColour);
            DB.AddParameter("@DateReleased", mThisStock.DateReleased);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Availability", mThisStock.Availability);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PhoneNo", ThisStock.PhoneNo);
            DB.AddParameter("@PhoneDescription", mThisStock.PhoneDescription);
            DB.AddParameter("@PhoneColour", mThisStock.PhoneColour);
            DB.AddParameter("@DateReleased", mThisStock.DateReleased);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Availability", mThisStock.Availability);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PhoneNo", mThisStock.PhoneNo);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByPhoneColour(string PhoneColour)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PhoneColour", PhoneColour);
            DB.Execute("sproc_tblStock_FilterByPhoneColour");
            PopulateArray(DB);


        }
        

        void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //object for data connection
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStock AnStock = new clsStock();
                //read in the fields from the current record
                AnStock.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AnStock.PhoneNo = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneNo"]);
                AnStock.PhoneDescription = Convert.ToString(DB.DataTable.Rows[Index]["PhoneDescription"]);
                AnStock.PhoneColour = Convert.ToString(DB.DataTable.Rows[Index]["PhoneColour"]);
                AnStock.DateReleased = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateReleased"]);
                AnStock.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                //add the records to the private data member
                mStockList.Add(AnStock);
                //point at the next record
                Index++;



            }
        }

    } 
}
