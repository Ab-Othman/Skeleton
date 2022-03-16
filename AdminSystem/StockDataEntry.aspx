<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-top: 33px">
    <form id="form1" runat="server">
        <asp:Label ID="lblPhoneNo" runat="server" Text="Phone ID Number" width="303px"></asp:Label>
        <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPhoneDescription" runat="server" Text="Phone Description" width="303px"></asp:Label>
            <asp:TextBox ID="txtPhoneDescription" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPhoneColour" runat="server" Text="Phone Colour" width="303px"></asp:Label>
            <asp:TextBox ID="txtPhoneColour" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateReleased" runat="server" Text="Date Released" width="303px"></asp:Label>
            <asp:TextBox ID="txtDateReleased" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="303px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Text="Availability" OnCheckedChanged="chkActive_CheckedChanged" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
    </form>
</body>
</html>
