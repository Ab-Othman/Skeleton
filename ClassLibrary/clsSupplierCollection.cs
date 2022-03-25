using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        //private data member for list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();

        public clsSupplierCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure 
            DB.Execute("sproc_tblSupplier_SelectAll");
            //get count of records
            RecordCount = DB.Count;
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank address
                clsSupplier ASupplier = new clsSupplier();
                //read in fields from current record
                ASupplier.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ASupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["Supplierid"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.ShippingFromAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingFromAddress"]);
                ASupplier.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ASupplier.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                ASupplier.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                //add record to the private data member 
                mSupplierList.Add(ASupplier);
                //point at the next record
                Index++;
            }
            //create items of tests data
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierName = "huawei";
            TestItem.Email = "huawei@huawei.co.uk";
            TestItem.ShippingFromAddress = "China";
            TestItem.PhoneNumber = "07559983467";
            TestItem.DateAdded = System.DateTime.Now.Date;
            //add the item to the test line
            mSupplierList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsSupplier();
            //set properties 
            TestItem.Active = true;
            TestItem.SupplierID = 3;
            TestItem.SupplierName = "huawei";
            TestItem.Email = "huawei@huawei.co.uk";
            TestItem.ShippingFromAddress = "China";
            TestItem.PhoneNumber = "07559983467";
            TestItem.DateAdded = System.DateTime.Now.Date;
            //add item to test list
            mSupplierList.Add(TestItem);
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
        public clsSupplier ThisSupplier { get; set; }
    }
      
        
}