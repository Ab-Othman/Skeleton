<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffId" runat="server" Text="Staff ID" width="199px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" Height="19px" Width="197px"></asp:TextBox>
        <p>
            <asp:Label ID="lblStaffFirstName" runat="server" Height="23px" Text="Staff First Name" width="199px"></asp:Label>
            <asp:TextBox ID="txtStaffFirstName" runat="server" Height="16px" Width="201px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffLastName" runat="server" Height="22px" Text="Staff Last Name" width="199px"></asp:Label>
            <asp:TextBox ID="txtStaffLastName" runat="server" Height="16px" Width="202px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffEmail" runat="server" Height="16px" Text="Staff Email" width="199px"></asp:Label>
            <asp:TextBox ID="txtStaffEmail" runat="server" Height="16px" Width="202px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffPhoneNumber" runat="server" Height="23px" Text="Staff Phone Number" width="199px"></asp:Label>
            <asp:TextBox ID="txtStaffPhoneNumber" runat="server" Height="21px" Width="201px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffWeeklyContractedHours" runat="server" Height="20px" Text="Staff Weekly Contracted Hours" width="199px"></asp:Label>
            <asp:TextBox ID="txtStaffWeeklyContractedHours" runat="server" Height="16px" Width="200px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkManagement" runat="server" Text="Management" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
