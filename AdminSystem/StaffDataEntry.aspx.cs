using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            if (StaffId != -1)
            {
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ThisStaff.Find(StaffId);
        txtStaffId.Text = Staff.ThisStaff.StaffId.ToString();
        txtStaffFirstName.Text = Staff.ThisStaff.StaffFirstName;
        txtStaffLastName.Text = Staff.ThisStaff.StaffLastName;
        txtStaffEmail.Text = Staff.ThisStaff.StaffEmail;
        txtStaffPhoneNumber.Text = Staff.ThisStaff.StaffPhoneNumber.ToString();
        txtStaffWeeklyContractedHours.Text = Staff.ThisStaff.StaffWeeklyContractedHours.ToString();
        txtStaffStartDate.Text = Staff.ThisStaff.StaffStartDate.ToString();
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();

        //capture the StaffFirstName
        Int32 StaffId = Convert.ToInt32(txtStaffId.Text);
        string StaffFirstName = txtStaffFirstName.Text;
        string StaffLastName = txtStaffLastName.Text;
        string StaffEmail = txtStaffEmail.Text;
        string StaffPhoneNumber = txtStaffPhoneNumber.Text;
        string StaffWeeklyContractedHours = txtStaffPhoneNumber.Text;
        string StaffStartDate = txtStaffStartDate.Text;
        string Error =  "";
        Error = AnStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPhoneNumber, StaffWeeklyContractedHours, StaffStartDate);
        if (Error == "")
        {
            AnStaff.StaffId = StaffId;
            AnStaff.StaffId = Convert.ToInt32(StaffId);
            AnStaff.StaffFirstName = StaffFirstName;
            AnStaff.StaffLastName = StaffLastName;
            AnStaff.StaffPhoneNumber = Convert.ToInt32(StaffPhoneNumber);
            AnStaff.StaffEmail = StaffEmail;
            AnStaff.StaffWeeklyContractedHours = Convert.ToInt32(StaffWeeklyContractedHours);
            AnStaff.StaffStartDate = Convert.ToDateTime(StaffStartDate);
            AnStaff.Management = chkManagement.Checked;

            clsStaffCollection StaffList = new clsStaffCollection();
            if (StaffId == -1)
            {
                StaffList.ThisStaff = AnStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffId);
                StaffList.ThisStaff = AnStaff;
                StaffList.Update();
            }
            Response.Redirect("StaffList.aspx");
        }
        else
        { 
            lblError.Text = Error;
        }
    }

    protected void Find_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffId.Text);
        Found = AnStaff.Find(StaffId);
        if (Found == true)
        {
            txtStaffFirstName.Text = AnStaff.StaffFirstName;
            txtStaffLastName.Text = AnStaff.StaffLastName;
            txtStaffEmail.Text = AnStaff.StaffEmail;
            txtStaffPhoneNumber.Text = AnStaff.StaffPhoneNumber.ToString();
            txtStaffWeeklyContractedHours.Text = AnStaff.StaffWeeklyContractedHours.ToString();
            txtStaffStartDate.Text = AnStaff.StaffStartDate.ToString();
        }
    }
}