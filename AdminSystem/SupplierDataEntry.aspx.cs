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
        //create a new instance
        clsSupplier ASupplier = new clsSupplier();
        //capture supplier name
        string SupplierName = txtSupplierName.Text;
        //capture phone number 
        string PhoneNumber = txtPhoneNumber.Text;
        //capture email
        string Email = txtEmail.Text;
        //capture Shipping from address
        string ShippingFromAddress = txtShippingFromAddress.Text;
        //capture date
        string DateAdded = txtDateAdded.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ASupplier.Valid(PhoneNumber, Email, DateAdded, ShippingFromAddress, SupplierName);
        if (Error == "")
        {
            //capture the supplier name
            ASupplier.SupplierName = SupplierName;
            //capture the phone number
            ASupplier.PhoneNumber = PhoneNumber;
            //capture email
            ASupplier.Email = Email;
            //capture shipping from address
            ASupplier.ShippingFromAddress = ShippingFromAddress;
            //capture date
            ASupplier.DateAdded = Convert.ToDateTime(DateAdded);
            //store the address in the session object
            Session["ASupplier"] = ASupplier;
            //redirect to viewer page
            Response.Write("SupplierList.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;

        }
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the class
        clsSupplier ASupplier = new clsSupplier();
        //variable to store primary key
        Int32 SupplierID;
        //variable to store the result of find operation
        Boolean Found = false;
        //get primary key entered by user
        SupplierID = Convert.ToInt32( txtSupplierID.Text);
        //find the record
        Found = ASupplier.Find(SupplierID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtPhoneNumber.Text = ASupplier.PhoneNumber;
            txtEmail.Text = ASupplier.Email;
            txtDateAdded.Text = ASupplier.DateAdded.ToString();
            txtShippingFromAddress.Text = ASupplier.ShippingFromAddress;
            txtSupplierName.Text = ASupplier.SupplierName;
            
        }
    }
}