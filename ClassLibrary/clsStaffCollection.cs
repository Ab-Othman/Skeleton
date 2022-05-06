using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffPhoneNumber", mThisStaff.StaffPhoneNumber);
            DB.AddParameter("@StaffWeeklyContractedHours", mThisStaff.StaffWeeklyContractedHours);
            DB.AddParameter("@StaffStartDate", mThisStaff.StaffStartDate);
            DB.AddParameter("@Management", mThisStaff.Management);

            return DB.Execute("sproc_tblStaff_Insert");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffPhoneNumber", mThisStaff.StaffPhoneNumber);
            DB.AddParameter("@StaffWeeklyContractedHours", mThisStaff.StaffWeeklyContractedHours);
            DB.AddParameter("@StaffStartDate", mThisStaff.StaffStartDate);
            DB.AddParameter("@Management", mThisStaff.Management);

            DB.Execute("sproc_tblStaff_Update");

        }


        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public void AreEqual(int count1, int count2)
        {
            throw new NotImplementedException();
        }

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
        }
    
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstName"]);
                AnStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["StaffLastName"]);
                AnStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AnStaff.StaffPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffPhoneNumber"]);
                AnStaff.StaffWeeklyContractedHours = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffWeeklyContractedHours"]);
                AnStaff.Management = Convert.ToBoolean(DB.DataTable.Rows[Index]["Management"]);
                AnStaff.StaffStartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffStartDate"]);
                mStaffList.Add(AnStaff);
                Index++;
            }
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByStaffLastName(string StaffLastName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffLastName", StaffLastName);
            DB.Execute("sproc_tblStaff_FilterByStaffLastName");
            PopulateArray(DB);
        }

    }
}