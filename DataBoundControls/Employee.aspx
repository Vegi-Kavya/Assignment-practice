<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="DataBoundControl.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 172px;
        }
        .auto-style2 {
            width: 272px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>Employee Details
            <table style="border:2px solid red;width:300px;text-align:left;padding-top:2px;
                  background-color:Lime;border-radius:2px;Font-Size:20px"></table>
            <asp:Repeater ID="RP1" runat="server"  >        
              
            <HeaderTemplate>
                <table style="width:200px;padding-top:0px;background-color:gold">
                    <tr>
                        <td style="font-size:20px;text-align:center;height:48px"></td>
                        <asp:Label ID="lbl1" runat="server" Text="Table of Employee Details"></asp:Label>
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemTemplate>
                <table style="width:100%;">
                   <tr>
                      <td class="auto-style1">
                         <asp:Label ID="label1" runat="server" Text="EmpID"></asp:Label>
                      </td>
                      <td class="auto-style2">&nbsp;
                         <asp:Label ID="label7" runat="server" Text='<%#Eval("EmpID") %>'></asp:Label>
                      </td>
                      <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                         <asp:Label ID="label2" runat="server" Text="EmpName"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;
                         <asp:Label ID="label8" runat="server" Text='<%#Eval("EmpName") %>'></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                     <asp:Label ID="label3" runat="server" Text="EmpEmailID"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;
                     <asp:Label ID="label9" runat="server" Text='<%#Eval("EmpEmailID") %>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                     <asp:Label ID="label4" runat="server" Text="EmpMobileNum"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;
                     <asp:Label ID="label10" runat="server" Text='<%#Eval("EmpMobileNum") %>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="label5" runat="server" Text="EmpImage"></asp:Label>
                </td>
                <td rowspan="5" class="auto-style2">&nbsp;
                    <asp:Image ID="img1" runat="server" Width="100px" ImageUrl='<%#Eval("EmpImage") %>' />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                      <asp:Label ID="label6" runat="server" Text="EmpGender"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;
                      <asp:Label ID="label11" runat="server" Text='<%#Eval("EmpGender") %>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
         </table>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ></asp:SqlDataSource>
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
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [EmployeeTable]"></asp:SqlDataSource>
        </div>       
    </form>
</body>
</html>
