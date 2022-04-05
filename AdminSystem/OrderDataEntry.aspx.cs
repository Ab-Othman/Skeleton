using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture order details
        string OrderNo = txtOrderNo.Text;
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
            AnOrder.OrderNo = int.Parse(OrderNo);
            AnOrder.CustomerUserId = int.Parse(CustomerUserId);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.ShippingAddress = ShippingAddress;
            AnOrder.PaymentMethod = PaymentMethod;
            AnOrder.PaymentReceived = chkPaymentReceived.Checked;
            AnOrder.OrderStatus = OrderStatus;

            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();
            //set the ThisOrder property
            OrderList.ThisOrder = AnOrder;
            //add the new record
            OrderList.Add();
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