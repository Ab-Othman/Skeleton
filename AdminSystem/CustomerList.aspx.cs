using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }


    }

    void DisplayCustomers()
    {
        //creatw an instance of the customers ollection
        clsCustomerCollection Customers = new clsCustomerCollection();

        lstCustomerList.DataSource = Customers.CustomerList;

        //set the name of primary key
        lstCustomerList.DataValueField = "CustomerUserId";

        //set the data field to display
        lstCustomerList.DataTextField = "CustomerFullName";

        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session objec to indicate ths is a new recoed
        Session["CustomerUserId"] = -1;

        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

}