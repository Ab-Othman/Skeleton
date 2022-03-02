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
        clsOrder AnOrder = new clsOrder();

        AnOrder = (clsOrder)Session["AnOrder"];

        Response.Write(AnOrder.OrderNo);
        Response.Write(AnOrder.CustomerUserId);
        Response.Write(AnOrder.OrderDate);
        Response.Write(AnOrder.ShippingAddress);
        Response.Write(AnOrder.PaymentMethod);
        Response.Write(AnOrder.PaymentReceived);
        Response.Write(AnOrder.OrderStatus);
    }
}