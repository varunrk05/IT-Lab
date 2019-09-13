<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="LoginPage.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDisp" runat="server"></asp:Label><br />
            <asp:Button ID="btnLogout" runat="server" Text="Log Out" OnClick="btnLogout_Click" />
        </div>
    </form>
</body>
</html>
