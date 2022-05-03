using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();

        //capture the StaffFirstName
        AnStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        AnStaff.StaffFirstName = txtStaffFirstName.Text;
        AnStaff.StaffLastName = txtStaffLastName.Text;
        AnStaff.StaffEmail = txtStaffEmail.Text;
        AnStaff. StaffPhoneNumber = Convert.ToInt32(txtStaffPhoneNumber.Text);
        AnStaff. StaffWeeklyContractedHours = Convert.ToInt32(txtStaffPhoneNumber.Text);
        //store the StaffFirstName in the session object
        Session["AnStaff"] = AnStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");


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
        }
    }
}