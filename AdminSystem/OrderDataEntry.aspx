<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderNo" runat="server" Text="Order Number" width="112px"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server" TextMode="Number"></asp:TextBox>
        &nbsp;<p>
            <asp:Label ID="lblCustomerUserId" runat="server" Text="Customer User ID" width="112px"></asp:Label>
        <asp:TextBox ID="txtCustomerUserId" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" width="112px"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" TextMode="Date"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblShippingAddress" runat="server" Text="Shipping Address" width="112px"></asp:Label>
        <asp:TextBox ID="txtShippingAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPaymentMethod" runat="server" Text="Payment Method" width="112px"></asp:Label>
        <asp:TextBox ID="txtPaymentMethod" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPaymentReceived" runat="server" Text="Payment Received"></asp:Label>
            <asp:CheckBox ID="chkPaymentReceived" runat="server" />
        </p>
        <p>
            <asp:Label ID="lblOrderStatus" runat="server" Text="Order Status" width="112px"></asp:Label>
        <asp:TextBox ID="txtOrderStatus" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
