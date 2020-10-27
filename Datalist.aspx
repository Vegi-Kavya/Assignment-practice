<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Datalist.aspx.cs" Inherits="AspSession.Datalist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>the datalist shows the data of  datatable</p>
            <asp:DataList ID="datalist1" runat="server" Width="100px" Height="98px">
                <ItemTemplate>
                    <asp:Table ID="table1" runat="server" CellPadding="2" CellSpacing="0"
                        Border="1" style="width:50px;height:50px;background-color:aqua"></asp:Table>
                    <tr>
                        <td>
                            <strong>ID</strong><span class="city"><%# Eval("ID")%></span><br />
                            <strong>Name</strong><span class="postal address"><%# Eval("Name")%></span><br />
                            <strong>Email</strong><span class="country"><%# Eval("Email")%></span><br />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:DataList>
            
        </div>
    </form>
</body>
</html>
