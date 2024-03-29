﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerUserId" runat="server" Text="Customer User Id "></asp:Label>
        <asp:TextBox ID="txtCustomerUserId" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="margin-left: 3px" Text="Find" Width="75px" />
        <p>
            <asp:Label ID="lblCustomerFullName" runat="server" Text="Customer Full Name " width="113px"></asp:Label>
            <asp:TextBox ID="txtCustomerFullName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerPhoneNumber" runat="server" Text="Customer Phone Number " width="113px"></asp:Label>
        <asp:TextBox ID="txtCustomerPhoneNumber" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerEmailId" runat="server" Text="Customer Email Id " width="113px"></asp:Label>
            <asp:TextBox ID="txtCustomerEmailId" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerAccountCreated" runat="server" Text="Customer Account Created " width="113px"></asp:Label>
        <asp:TextBox ID="txtCustomerAccountCreated" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerAddress" runat="server" Text="Customer Address " width="113px"></asp:Label>
            <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkSubscribedToReceiveMail" runat="server" Text="Subscribed To Receive Mail " />
        </p>
        <p>
            &nbsp;<asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
