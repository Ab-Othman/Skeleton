using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier ASupplier = new clsSupplier();
        //get the data from the session object
        ASupplier = (clsSupplier)Session["ASupplier"];
        //display the supplier name for this entry
        Response.Write(ASupplier.SupplierID);
       
        Response.Write(ASupplier.PhoneNumber += "<br/>");

        Response.Write(ASupplier.Email +="<br/>");

        Response.Write(ASupplier.DateAdded);

         Response.Write(ASupplier.ShippingFromAddress += "<br/>");

        Response.Write(ASupplier.SupplierName += "<br/>"); 

        Response.Write(ASupplier.Active);

    }
}