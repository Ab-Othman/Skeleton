using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of class
        clsStaff AnStaff = new clsStaff();
        //Get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the StaffId for this entry
        Response.Write(AnStaff.StaffId);
        Response.Write(AnStaff.StaffFirstName);
        Response.Write(AnStaff.StaffLastName);
        Response.Write(AnStaff.StaffEmail);
        Response.Write(AnStaff.StaffPhoneNumber);
        Response.Write(AnStaff.StaffWeeklyContractedHours);

    }

}

