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
        //create a new instance of clsSupplier
        clsSupplier ASupplier = new clsSupplier();
        
        //capture the SupplierName
        ASupplier.SupplierName = txtSupplierName.Text;
        //capture the ShippingFrom
        ASupplier.ShippingFromAddress = txtShippingFromAddress.Text;
        //capture Email
        ASupplier.Email = txtEmail.Text;
        //capture PhoneNumber
        ASupplier.PhoneNumber = txtPhoneNumber.Text;
        //capture SupplierID
        ASupplier.SupplierID = Convert.ToInt32(txtSupplierID.Text);
        //capture date
        ASupplier.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        //capture active
        ASupplier.Active = chkActive.Checked;
        //store the address in the session object
        Session["ASupplier"] = ASupplier;
        //navigate to the viewer page
        Response.Redirect("SupplierViewer.aspx");
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