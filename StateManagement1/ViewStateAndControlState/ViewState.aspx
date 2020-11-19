<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="ViewStateAndControlView.ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4>This is demo of View State</h4>
            <asp:Button ID="Button1" runat="server" Text="Hitcount" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
