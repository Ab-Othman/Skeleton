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
        if(IsPostBack == false)
        {
            //update the list box
            DisplaySuppliers();
        }
    }
   void DisplaySuppliers()
    {
        //create an intance of the Supplier collection
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //set the data source to list of addresses in the collection
        lstSupplierList.DataSource = Suppliers.SupplierList;
        //set name of primary key
        lstSupplierList.DataValueField = "SupplierID";
        //set the data field to display
        lstSupplierList.DataTextField = "SupplierName";
        //bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["SupplierID"] = -1;
        //redirect to the data entry page
        Response.Redirect("SupplierDataEntry.aspx");
    }
}