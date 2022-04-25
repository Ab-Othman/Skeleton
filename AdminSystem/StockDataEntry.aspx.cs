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
        string PhoneNo = txtPhoneNo.Text;
        string PhoneDescription = txtPhoneDescription.Text;
        string PhoneColour = txtPhoneColour.Text;
        string DateReleased = txtDateReleased.Text;
        string Price = txtPrice.Text;
        string Error = "";
        //validate the error
        Error = AnStock.Valid(PhoneDescription, PhoneColour, DateReleased, Price);
        if (Error == "")
        {
            //capture the PhoneDescription
            AnStock.PhoneDescription = PhoneDescription;
            //capture the phonecolour
            AnStock.PhoneColour = PhoneColour;
            //capture the datereleased
            AnStock.DateReleased = Convert.ToDateTime(DateReleased);
            //store the address in the session object
            Session["AnStock"] = AnStock;
            //navigate to the viewer page 
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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