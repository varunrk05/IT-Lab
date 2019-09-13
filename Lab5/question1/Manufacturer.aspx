<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manufacturer.aspx.cs" Inherits="question1.Manufacturer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlManuf" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlManuf_SelectedIndexChanged" />
            <br />
            <asp:TextBox ID="tbModel" runat="server" />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="submitData" Text="Submit"/>
        </div>
    </form>
</body>
</html>
