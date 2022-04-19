<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 742px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstSupplierList" runat="server" Height="542px" Width="366px"></asp:ListBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" Width="54px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="51px" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter a Supplier Name"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" Height="16px" style="margin-left: 10px; margin-top: 1px" Width="174px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" Width="51px" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="margin-left: 8px" Text="Clear" />
        </p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    </form>
</body>
</html>
