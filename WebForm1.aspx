﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AspFirstApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%Response.Write("My first page created in iis express"); %><br />
            <%Response.Write("This is an example of website project template"); %>
        </div>
        <p>Web forms are web pages in asp.net</p>
    </form>
</body>
</html>
