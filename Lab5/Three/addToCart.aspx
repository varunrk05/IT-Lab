<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addToCart.aspx.cs" Inherits="Three.addToCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Item(s):
            <asp:TextBox ID="tbItem" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add to Cart" OnClick="btnAdd_Click" />
            <br />
            <asp:Button ID="btnBack" runat="server" Text="Go Back" OnClick="btnBack_Click" />
        </div>
    </form>
</body>
</html>
