<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="firstPage.aspx.cs" Inherits="Two.firstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Name: <br />
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox><br />
            Enter Roll No: <br />
            <asp:TextBox ID="tbRoll" runat="server"></asp:TextBox><br />
            Select subject: <br />
            <asp:DropDownList ID="ddlSub" runat="server"></asp:DropDownList><br />
            <asp:Button ID="btnSub1" runat="server" Text="Submit" OnClick="btnSub1_Click"/>
        </div>
    </form>
</body>
</html>
