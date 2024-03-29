﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        {
            //get the number of the Supplier to be processed
            SupplierID = Convert.ToInt32(Session["SupplierID"]);
            if (IsPostBack == false)
            {
                //if this is not a new record
                if (SupplierID != -1 && SupplierID != 0)
                {
                    //display current data for the record
                    DisplaySuppliers();
                }
            }
        }

    }

    private void DisplaySuppliers()
    {
        //create an instance of supplier collection
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //set data source to list of suppliers in collection
        lstSupplierList.DataSource = Suppliers.SupplierList;
        //set name of primary key
        lstSupplierList.DataValueField = "SupplierID";
        //set data field to display
        lstSupplierList.DataTextField = "SupplierName";
        //bind data to list
        lstSupplierList.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["SupplierID"] = -1;
        //redirect to the data entry page
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 SupplierID;
        //if a record has been selected from the list
        if(lstSupplierList.SelectedIndex != -1)
        {
            //get primary key value of the record to edit
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the section object
            Session["SupplierID"] = SupplierID;
            //redirect to edit page
            Response.Redirect("SupplierDataEntry.aspx");
        }
        else //if no record selected
        {
            lblError.Text = "Please select a record from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value  of the record to be edited
        Int32 SupplierID;
        //if a record has been selected from the list
        if (lstSupplierList.SelectedIndex != 1)
        {
            //get primary key of the record to edit
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store data in session object
            Session["SupplierID"] = SupplierID;
            //redirect to delete page
            Response.Redirect("SupplierConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the supplier collection
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        ASupplier.ReportBySupplierName(txtFilter.Text);
        lstSupplierList.DataSource = ASupplier.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "SupplierID";
        //set the name of the field to display
        lstSupplierList.DataTextField = "SupplierName";
        //bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the supplier collection
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        ASupplier.ReportBySupplierName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstSupplierList.DataSource = ASupplier.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "SupplierID";
        //set the name of the field to display
        lstSupplierList.DataTextField = "SupplierName";
        //bind the data to the list
        lstSupplierList.DataBind(); 

    }
}