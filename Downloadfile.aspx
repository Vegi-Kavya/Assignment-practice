<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Downloadfile.aspx.cs" Inherits="Downloadfile.Downloadfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>click button to download a file</h3>
        <div>
              <asp:Button ID="button1" runat="server" Text="click to download file" OnClick="button1_Click" />
        </div>
        <br />
        <br />
    </form>
    <p>
        <asp:Label ID="label1" runat="server"></asp:Label>
    </p>
</body>
</html>
