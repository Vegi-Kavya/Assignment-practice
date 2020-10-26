<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calender.aspx.cs" Inherits="Calendar.Calender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="calendar1" runat="server" OnSelectionChanged="Page_Load"></asp:Calendar>
        </div>
    </form>
    <p>
        <asp:Label runat="server" ID="showdate"></asp:Label>
    </p>
</body>
</html>
