﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <br />
            <asp:Button ID="lblDeleteYes" runat="server" OnClick="lblDeleteYes_Click" Text="Yes" />
            <asp:Button ID="lblDeleteNo" runat="server" Text="No" />
        </div>
    </form>
</body>
</html>
