using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of the address to be Processed
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (SupplierID != -1)
            {
                //display current data for the record
                DisplaySuppliers();
            }
        }
    }

    private void DisplaySuppliers()
    {
        //create an instance of supplier book
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find record to update
        SupplierBook.ThisSupplier.Find(SupplierID);
        txtSupplierID.Text = SupplierBook.ThisSupplier.SupplierID.ToString();
        txtPhoneNumber.Text = SupplierBook.ThisSupplier.PhoneNumber.ToString();
        txtEmail.Text = SupplierBook.ThisSupplier.Email.ToString();
        txtShippingFromAddress.Text = SupplierBook.ThisSupplier.ShippingFromAddress.ToString();
        txtSupplierName.Text = SupplierBook.ThisSupplier.SupplierName.ToString();
        chkActive.Checked = SupplierBook.ThisSupplier.Active;
        txtDateAdded.Text = SupplierBook.ThisSupplier.DateAdded.ToString();

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
            //capture supplierid
            ASupplier.SupplierID = SupplierID;
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
            //capture active
            ASupplier.Active = chkActive.Checked;
            //create a new instance of the address collection
            clsSupplierCollection SupplierList = new clsSupplierCollection();

            //if this is a new record then add the data
            if (SupplierID == -1)
            {
                //set thisSuppliere property
                SupplierList.ThisSupplier = ASupplier;
                //add new record
                SupplierList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                SupplierList.ThisSupplier.Find(SupplierID);
                //set thisSupplierProperty
                SupplierList.ThisSupplier = ASupplier;
                //update the record
                SupplierList.Update();
            }
            //redirect back to the list page
            Response.Redirect("SupplierList.aspx");
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