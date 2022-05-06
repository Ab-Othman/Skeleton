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
        public clsStaff ThisStaff { get; set; }

        public void AreEqual(int count1, int count2)
        {
            throw new NotImplementedException();
        }

        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
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
    }
}