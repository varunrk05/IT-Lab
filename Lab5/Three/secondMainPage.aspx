<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="secondMainPage.aspx.cs" Inherits="Three.secondMainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnSub" runat="server" Text="Continue Shopping!" OnClick="btnSub_Click"/>
        </div>
    </form>
</body>
</html>
