<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bordercolorstyle.aspx.cs" Inherits="Bordercolorstyle.Bordercolorstyle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>BorderColor Property of a Web Control</h3>

        <asp:Table id="Table1" runat="server"
            CellPadding = "10" 
            CellSpacing="0"
            GridLines="Both"
            BorderWidth="3"
            BorderColor="blue">

            <asp:TableRow>
                <asp:TableCell>
                    Row 0, Col 0
                </asp:TableCell>
                <asp:TableCell>
                    Row 0, Col 1
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    Row 1, Col 0
                </asp:TableCell>
                <asp:TableCell>
                    Row 1, Col 1
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        </div>
        <div>
             <h3>BorderStyle Property of a Web Control</h3>

        <asp:Table id="Table2" runat="server"
            CellPadding = "10" 
            CellSpacing="0"
            GridLines="Both"
            BorderWidth="3"
            BorderColor="black"
            BorderStyle="double">

            <asp:TableRow>
                <asp:TableCell>
                    Row 0, Col 0
                </asp:TableCell>
                <asp:TableCell>
                    Row 0, Col 1
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    Row 1, Col 0
                </asp:TableCell>
                <asp:TableCell>
                    Row 1, Col 1
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    <div>
        <h3>Property of a Table Web Control</h3>
        <asp:Table id="Table3" runat="server"
            CellPadding = "20" 
            CellSpacing="10"
            GridLines="Both"
            BorderColor="Lightcoral"
            BorderWidth="5">
            <asp:TableRow>
                <asp:TableCell>
                    Row 0, Col 0
                </asp:TableCell>
                <asp:TableCell>
                    Row 0, Col 1
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    Row 1, Col 0
                </asp:TableCell>
                <asp:TableCell>
                    Row 1, Col 1
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        </div>
    </form>
</body>
</html>
