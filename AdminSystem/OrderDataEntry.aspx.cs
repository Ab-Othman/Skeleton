using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderNo != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
    
    }

    void DisplayOrder()
    {
        //create an instance of the order collection
        clsOrderCollection OrderList = new clsOrderCollection();
        //find the record to update
        OrderList.ThisOrder.Find(OrderNo);
        //Display the data for this record
        txtOrderNo.Text = OrderList.ThisOrder.OrderNo.ToString();
        txtCustomerUserId.Text = OrderList.ThisOrder.CustomerUserId.ToString();
        txtOrderDate.Text = OrderList.ThisOrder.OrderDate.ToString();
        txtShippingAddress.Text = OrderList.ThisOrder.ShippingAddress.ToString();
        txtPaymentMethod.Text = OrderList.ThisOrder.PaymentMethod.ToString();
        chkPaymentReceived.Checked = OrderList.ThisOrder.PaymentReceived;
        txtOrderStatus.Text = OrderList.ThisOrder.OrderStatus.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture order details
        int OrderNo = int.Parse(txtOrderNo.Text);
        string CustomerUserId = txtCustomerUserId.Text;
        string OrderDate = txtOrderDate.Text;
        string ShippingAddress = txtShippingAddress.Text;
        string PaymentMethod = txtPaymentMethod.Text;
        bool PaymentReceived = chkPaymentReceived.Checked;
        string OrderStatus = txtOrderStatus.Text;

        //varibale to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(OrderDate, ShippingAddress, PaymentMethod, OrderStatus);
        if (Error == "")
        {
            //capture order details
            AnOrder.OrderNo = OrderNo; 
            AnOrder.CustomerUserId = int.Parse(CustomerUserId);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.ShippingAddress = ShippingAddress;
            AnOrder.PaymentMethod = PaymentMethod;
            AnOrder.PaymentReceived = chkPaymentReceived.Checked;
            AnOrder.OrderStatus = OrderStatus;

            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();

            //if this is a new record i.e. OrderNo = -1 then add the data
            if (OrderNo == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            } 
            else //otherwise must be an update
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderNo);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update record
                OrderList.Update();
            }
            //redirect back to listpage
            Response.Redirect("OrderList.aspx");
        } 
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the class
        clsOrder AnOrder = new clsOrder();
        //variable to store primary key
        Int32 OrderNo;
        //variable to store the result of find operation
        Boolean Found = false;
        //get primary key entered by user
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //find the record
        Found = AnOrder.Find(OrderNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerUserId.Text = Convert.ToString(AnOrder.CustomerUserId);
            txtOrderDate.Text = (AnOrder.OrderDate).ToString("dd'/'MM'/'yyyy");
            txtShippingAddress.Text = AnOrder.ShippingAddress;
            txtPaymentMethod.Text = AnOrder.PaymentMethod;
            txtOrderStatus.Text = AnOrder.OrderStatus;

        }
    }
}