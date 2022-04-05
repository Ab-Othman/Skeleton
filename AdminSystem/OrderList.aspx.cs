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
        //if first time page is being displayed
        if (IsPostBack == false)
        {
            //update list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create instance of order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set data source to list of orders in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set name of primary key
        lstOrderList.DataValueField = "OrderNo";
        //set data field to display
        lstOrderList.DataTextField = "OrderDate";
        //bind data to the list
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }
}