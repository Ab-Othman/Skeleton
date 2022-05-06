<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="355px" Width="391px" OnSelectedIndexChanged="lstStaffList_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        </p>
        <p>
            <asp:Label ID="lblFilterStaffLastName" runat="server" Text="Enter Staff Last Name: "></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" Height="16px" Width="241px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="Button1_Click1" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
