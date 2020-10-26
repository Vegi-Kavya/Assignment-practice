<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Label1.aspx.cs" Inherits="Labelwebsite.Label1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>This is an example of document upload</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4>provide the below information</h4>
            <asp:Label ID="label1" runat="server" Text="username" ForeColor="LightCoral"></asp:Label>
            <asp:TextBox ID="textbox1" runat="server" BackColor="White" BorderColor="ForestGreen" BorderStyle="Double"></asp:TextBox>
            <br /><br />
            <asp:Label ID="label2" runat="server" Text="upload a file"></asp:Label>
            <asp:FileUpload ID="fileupload1" runat="server" />
        </div>
    </form>
</body>
</html>
