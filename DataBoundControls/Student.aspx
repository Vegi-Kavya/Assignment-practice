<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="DataBoundControl.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 206px;
        }
        .auto-style2 {
            width: 206px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
            width: 230px;
        }
        .auto-style5 {
            width: 230px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student Details</div>
                <table style="border:2px solid red;width:300px;text-align:left;padding-top:2px;
                  background-color:Lime;border-radius:2px;Font-Size:20px"></table>
            <asp:Repeater ID="RP1" runat="server"  >        
              
            <HeaderTemplate>
                <table style="width:200px;padding-top:0px;background-color:gold">
                    <tr>
                        <td style="font-size:20px;text-align:center;height:48px"></td>
                        <asp:Label ID="lbl1" runat="server" Text="Table of Student Details"></asp:Label>
                    </tr>
                </table>
            </HeaderTemplate>
           <ItemTemplate>
               <table style="width:100%;">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="label1" runat="server" Text="StuName"></asp:Label></td>
                <td class="auto-style4">
                    <asp:Label ID="label6" runat="server" Text='<%#Eval("StuName") %>'></asp:Label>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="label2" runat="server" Text="StuID"></asp:Label></td>
                <td class="auto-style5">&nbsp;
                    <asp:Label ID="label7" runat="server" Text='<%#Eval("StuID") %>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="label3" runat="server" Text="StuEmailID"></asp:Label></td>
                <td class="auto-style5">&nbsp;
                    <asp:Label ID="label8" runat="server" Text='<%#Eval("StuEmailID") %>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="label4" runat="server" Text="StuGender"></asp:Label></td>
                <td class="auto-style5">&nbsp;
                    <asp:Label ID="label9" runat="server" Text='<%#Eval("StuGender") %>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="label5" runat="server" Text="StuAge"></asp:Label></td>
                <td class="auto-style5">&nbsp;
                    <asp:Label ID="label10" runat="server" Text='<%#Eval("StuAge") %>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
           </ItemTemplate>
        <FooterTemplate>
            <table>
                    <tr>
                        <td>
                            @Developed  by Kavya<br />
                            @2020 All Copy Rights Reserved
                        </td>
                    </tr>
                </table>
        </FooterTemplate>
       </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT * FROM [StudentTable]"></asp:SqlDataSource>
    </form>
</body>
</html>
