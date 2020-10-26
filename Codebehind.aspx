<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Codebehind.aspx.cs" Inherits="Website1.Codebehind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="true"  Text="red" ForeColor="Red" OnCheckedChanged="RadioButton1_CheckedChanged" />
            <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="true" Text="green" ForeColor="green" OnCheckedChanged="RadioButton2_CheckedChanged" />
            <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="true"  Text="blue" ForeColor="blue" OnCheckedChanged="RadioButton3_CheckedChanged" />
        </div>
    </form>
</body>
</html>
