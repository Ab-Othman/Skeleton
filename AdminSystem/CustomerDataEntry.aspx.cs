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

    protected void btnOK_Click(Object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();

        string CustomerFullName = txtCustomerFullName.Text;

        string CustomerPhoneNumber = txtCustomerPhoneNumber.Text;

        string CustomerEmailId = txtCustomerEmailId.Text;

        string CustomerAccountCreated = txtCustomerAccountCreated.Text;

        string CustomerAddress = txtCustomerAddress.Text; ;

        string Error = "";

        Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerEmailId, CustomerAccountCreated, CustomerAddress);
        if (Error == "")
        {
            ACustomer.CustomerFullName = CustomerFullName;

            //capture customer phone number
            ACustomer.CustomerPhoneNumber = CustomerPhoneNumber;

            //capture customer email id
            ACustomer.CustomerEmailId = CustomerEmailId;

            //capture customer account create date
            ACustomer.CustomerAccountCreated = Convert.ToDateTime(CustomerAccountCreated);

            //capture customer address
            ACustomer.CustomerAddress = CustomerAddress;

            //store the customer in Session object
            Session["ACustomer"] = ACustomer;

            //redirectr to the viewer page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of class
        clsCustomer ACustomer = new clsCustomer();

        Int32 CustomerUserId;

        Boolean Found = false;
        CustomerUserId = Convert.ToInt32(txtCustomerUserId.Text);

        Found = ACustomer.Find(CustomerUserId);
        if(Found == true)
        {
            txtCustomerFullName.Text = ACustomer.CustomerFullName;
            txtCustomerPhoneNumber.Text = ACustomer.CustomerPhoneNumber;
            txtCustomerEmailId.Text = ACustomer.CustomerEmailId;
            txtCustomerAccountCreated.Text = ACustomer.CustomerAccountCreated.ToString();
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
            
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}