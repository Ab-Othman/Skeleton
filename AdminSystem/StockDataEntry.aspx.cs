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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Stock class
        clsStock AnStock = new clsStock();
        //variable to store the primary key
        Int32 PhoneNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        PhoneNo = Convert.ToInt32(txtPhoneNo.Text);
        //find the record
        Found = AnStock.Find(PhoneNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtPhoneNo.Text = AnStock.PhoneNo.ToString();
            txtPhoneDescription.Text = AnStock.PhoneDescription;
            txtPhoneColour.Text = AnStock.PhoneColour;
            txtDateReleased.Text = AnStock.DateReleased.ToString();
            txtPrice.Text = AnStock.Price.ToString();
             
        }
    }
}