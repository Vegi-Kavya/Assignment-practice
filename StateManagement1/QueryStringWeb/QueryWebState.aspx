<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryWebState.aspx.cs" Inherits="QueryStringsWeb.QueryWebState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 184px;
        }
        .auto-style2 {
            width: 335px;
        }
        .auto-style3 {
            width: 41px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <table class="auto-style1" border="1">
                <caption>Login Form</caption>
                <tr>
                    <td class="auto-style2">Username&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button3" runat="server" Text="Login" onclick="Button3_Click"/>&nbsp;
                        <asp:Button ID="Button4" runat="server" Text="Reset" onclick="Button4_Click"/>
                    </td>
                    <td>&nbsp;</td>
                    <td colspan="2">
                        <asp:Label ID="lblstatus" runat="server" ForeColor="Navy"></asp:Label>
                    </td>
                </tr>
            </table>
    </form>
</body>
</html>
