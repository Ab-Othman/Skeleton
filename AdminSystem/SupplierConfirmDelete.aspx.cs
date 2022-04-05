using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of record to be deleted
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of suppliers to be deleted from session object
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the supplier book class
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find record to delete
        SupplierBook.ThisSupplier.Find(SupplierID);
        //delete record
        SupplierBook.Delete();
        //redirect back to main page
        Response.Redirect("SupplierList.aspx");
    }
}