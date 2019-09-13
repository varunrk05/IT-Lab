<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="secondPage.aspx.cs" Inherits="Two.secondPage" %>

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
            <asp:Label ID="lblCount" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnInc" runat="server" OnClick="btnInc_Click" Text="Counter"/>
        </div>
    </form>
</body>
</html>
