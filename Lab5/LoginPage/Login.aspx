﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginPage.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter the user name:<br />
            <asp:TextBox ID="tbUserID" runat="server"></asp:TextBox><br />
            Enter the password:<br />
            <asp:TextBox ID="tbPass" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
        </div>
    </form>
</body>
</html>
