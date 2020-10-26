<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="website.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <button>clickme</button>
            <asp:Button ID="button1" runat="server" Text="clickon" OnClick="button1_Click" ForeColor="BlueViolet" />
        </div>
    </form>
</body>
</html>
