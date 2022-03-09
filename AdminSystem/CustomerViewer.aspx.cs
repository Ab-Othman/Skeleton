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
        clsCustomer ACustomer = new clsCustomer();

        ACustomer = (clsCustomer)Session["ACustomer"];

        Response.Write(ACustomer.CustomerUserId );

        Response.Write(ACustomer.CustomerFullName += "<br/>");

        Response.Write(ACustomer.CustomerPhoneNumber += "<br/>");

        Response.Write(ACustomer.CustomerEmailId += "<br/>");

        Response.Write(ACustomer.CustomerAccountCreated);

        Response.Write(ACustomer.CustomerAddress += "<br/>");

        Response.Write(ACustomer.SubscribedToReceiveMail);

        
    }
}