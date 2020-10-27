<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AspSession.aspx.cs" Inherits="AspSession.AspSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Provide following details</h3>
            Email:<asp:TextBox ID="email" runat="server" TextMode="email" OnTextChanged="textbox1_TextChanged"></asp:TextBox><br /><br />
            Password:<asp:TextBox ID="password" runat="server" TextMode="password"></asp:TextBox><br /><br />
            Mobile:<asp:TextBox ID="mobile" runat="server" TextMode="phone"></asp:TextBox><br /><br />
            <asp:Button ID="button1" runat="server" Text="Login" />
        </div>
        <p>
            <asp:Label ID="label1" runat="server"></asp:Label>
            <asp:Label ID="label2" runat="server"></asp:Label>
        </p>
    </form>

</body>
</html>
