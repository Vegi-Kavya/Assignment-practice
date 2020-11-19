<%@ Page  Trace="true" Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="StateManagementWeb.About" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 325px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="Button1" runat="server" Text="ClickMe" onclick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Another WebPage" postbackurl="~/HiddenCount.aspx"/>
            <asp:HiddenField ID="hiddenfield" runat="server" Value="0" />
            
        </p>
    </form>
</body>
</html>
