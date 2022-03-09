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
        clsStock AnStock = new clsStock();
        AnStock = (clsStock)Session["AnStock"];
        Response.Write(AnStock.PhoneNo + "<br />");
        Response.Write(AnStock.PhoneDescription + "<br />");
        Response.Write(AnStock.PhoneColour + "<br />");
        Response.Write(AnStock.DateReleased + "<br />");
        Response.Write(AnStock.Price + "<br />");
        Response.Write(AnStock.Availability + "<br />");
    }
}