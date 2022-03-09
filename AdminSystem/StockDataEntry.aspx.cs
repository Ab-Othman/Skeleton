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

 

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        AnStock.PhoneNo = Convert.ToInt32(txtPhoneNo.Text);
        AnStock.PhoneDescription = txtPhoneDescription.Text;
        AnStock.PhoneColour = txtPhoneColour.Text;
        AnStock.DateReleased = Convert.ToDateTime(txtDateReleased.Text);
        AnStock.Price = Convert.ToDouble(txtPrice.Text);
        AnStock.Availability = chkActive.Checked;



        //store the address in the session object
        Session["AnStock"] = AnStock;


        //navigate to the viewer page 
        Response.Redirect("StockViewer.aspx");
    }

    protected void chkActive_CheckedChanged(object sender, EventArgs e)
    {

    }
}