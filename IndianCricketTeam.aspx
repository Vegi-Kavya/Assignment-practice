<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndianCricketTeam.aspx.cs" Inherits="WebFormsInAsp.IndianCricketTeam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataGrid ID="datagrid1" runat="server" OnSelectedIndexChanged="datagrid1_SelectedIndexChanged"></asp:DataGrid>
        </div>
    </form>
</body>
</html>
