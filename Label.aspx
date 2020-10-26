<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Label.aspx.cs" Inherits="CodebehindLabel.Label" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Username" runat="server" ToolTip="Enter your name"></asp:Label>
            <asp:TextBox ID="textbox1" runat="server"></asp:TextBox><br />
            <asp:HyperLink ID="Hyperlink1" runat="server" Text="SheShore" NavigateUrl="~/Label.aspx"></asp:HyperLink>
        </div>
        <p>
            <asp:Button ID="buttton1" runat="server" Text="submit" OnClick="button1_Click" />
        </p>
    </form>
    <asp:Label ID="userinput" runat="server"></asp:Label>
</body>
</html>
