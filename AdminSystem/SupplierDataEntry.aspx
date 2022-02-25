<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 353px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplierID" runat="server" Text="Supplier ID" width="92px"></asp:Label>
            <asp:TextBox ID="txtSupplierID" runat="server" style="margin-left: 7px"></asp:TextBox>
        </div>
        <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="margin-left: 9px"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email" width="92px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 9px" Width="120px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="92px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="margin-left: 10px"></asp:TextBox>
        <br />
        <asp:Label ID="lblShippingFromAddress" runat="server" Text="Shipping From" width="92px"></asp:Label>
        <asp:TextBox ID="txtShippingFromAddress" runat="server" style="margin-left: 11px" Width="118px"></asp:TextBox>
        <br />
        <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name" width="92px"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server" style="margin-left: 11px" Width="119px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="margin-left: 6px" Text="Cancel" />
    </form>
</body>
</html>
