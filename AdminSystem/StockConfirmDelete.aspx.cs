using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 PhoneNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        PhoneNo = Convert.ToInt32(Session["PhoneNo"]);

    }

    protected void lblDeleteYes_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ThisStock.Find(PhoneNo);
        Stock.Delete();
        Response.Redirect("StockList.aspx");
    }
}