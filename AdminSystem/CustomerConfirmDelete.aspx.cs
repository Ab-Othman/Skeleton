using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 CustomerUserId;
    protected void Page_Load(object sender, EventArgs e)
    {

        //get the number of customers to be deleted from the session object
        CustomerUserId = Convert.ToInt32(Session["CustomerUserId"]);
    }



    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();

        //find the record to delete
        CustomerBook.ThisCustomer.Find(CustomerUserId);

        //delete the record
        CustomerBook.Delete();

        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}