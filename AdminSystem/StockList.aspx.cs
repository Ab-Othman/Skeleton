using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
    
{
    Int32 PhoneNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        PhoneNo = Convert.ToInt32(Session["PhoneNo"]);
        if(IsPostBack == false)
        {
            if (PhoneNo != -1)
            {
                //update the list box
                DisplayStocks();
            }
        }
    }

    void DisplayStocks()
    {
        //create an instance of the stock collection
        clsStockCollection Stock = new clsStockCollection();
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "PhoneNo";
        lstStockList.DataTextField = "PhoneDescription";
        lstStockList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void lblError_Click(object sender, EventArgs e)
    {
        Int32 PhoneNo;
        if(lstStockList.SelectedIndex != -1)
        {
            PhoneNo = Convert.ToInt32(lstStockList.SelectedValue);
            Session["PhoneNo"] = PhoneNo;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

        Int32 PhoneNo;
        if (lstStockList.SelectedIndex != -1)
        {
            PhoneNo = Convert.ToInt32(lstStockList.SelectedValue);
            Session["PhoneNo"] = PhoneNo;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ReportByPhoneColour(txtFilter.Text);
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "PhoneNo";
        lstStockList.DataTextField = "PostCode";
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ReportByPhoneColour("");
        txtFilter.Text = "";
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "PhoneNo";
        lstStockList.DataTextField = "PostCode";
        lstStockList.DataBind();
    }
}