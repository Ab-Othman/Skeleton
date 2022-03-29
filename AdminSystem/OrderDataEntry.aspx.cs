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
        AnOrder.OrderNo = int.Parse(txtOrderNo.Text);
        AnOrder.CustomerUserId = int.Parse(txtCustomerUserId.Text);
        AnOrder.OrderDate = DateTime.Parse(txtOrderDate.Text);
        AnOrder.ShippingAddress = txtShippingAddress.Text;
        AnOrder.PaymentMethod = txtPaymentMethod.Text;
        AnOrder.PaymentReceived = chkPaymentReceived.Checked;
        AnOrder.OrderStatus = txtOrderStatus.Text;
        //store the details in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
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