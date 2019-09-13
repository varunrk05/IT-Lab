<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainPage.aspx.cs" Inherits="Three.mainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Name:<br />
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnMain" runat="server" Text="Shop!" OnClick="btnMain_Click" />
        </div>
    </form>
</body>
</html>
