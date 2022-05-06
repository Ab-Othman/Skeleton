using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "StaffLastName";
        lstStaffList.DataBind();
    }

    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {

        Int32 StaffId;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByStaffLastName(txtFilter.Text);
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "StaffLastName";
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByStaffLastName("");
        txtFilter.Text = "";
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "StaffLastName";
        lstStaffList.DataBind();
    }
}