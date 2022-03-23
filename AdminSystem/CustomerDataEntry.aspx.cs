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

        ACustomer.CustomerUserId = Convert.ToInt32(txtCustomerUserId.Text);

        ACustomer.CustomerFullName = txtCustomerFullName.Text;

        ACustomer.CustomerPhoneNumber= txtCustomerPhoneNumber.Text;

        ACustomer.CustomerEmailId = txtCustomerEmailId.Text;

        ACustomer.CustomerAccountCreated = Convert.ToDateTime(txtCustomerAccountCreated.Text);

        ACustomer.CustomerAddress = txtCustomerAddress.Text;

        ACustomer.SubscribedToReceiveMail = chkSubscribedToReceiveMail.Checked;
        
        Session["ACustomer"] = ACustomer;

        Response.Redirect("CustomerViewer.aspx");

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
}