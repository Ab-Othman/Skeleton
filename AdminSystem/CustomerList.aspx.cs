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


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerUserId;

        //if the record has been selected from the list
        if(lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerUserId = Convert.ToInt32(lstCustomerList.SelectedValue);

            //store the data in the session object
            Session["CustomerUserId"] = CustomerUserId;

            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        } else
        {
            lblError.Text = "please select a record to edit from the list";
        }
    }    

    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        Int32 CustomerUserId;

        //if record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerUserId = Convert.ToInt32(lstCustomerList.SelectedValue);

            //store the data in the session object
            Session["CustomerUserId"] = CustomerUserId;

            //redirect to the delete page 
            Response.Redirect("CustomerConfirmDelete.aspx");

        }
        else //if no record has been selected
        {
            lblError.Text = "Pleasse select a record to delete from the list";
        }
    }
}
