<%@ Page trace="true" Language="C#" AutoEventWireup="true" CodeBehind="WebCount.aspx.cs" Inherits="SateManagementDemoWeb.WebCount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="HitCount" onclick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="Open another web page" postbackurl="~/GetHiddenFieldValues.aspx"/>
            <asp:HiddenField ID="hfcount" runat="server" Value="0" />
        </div>
    </form>
</body>
</html>
