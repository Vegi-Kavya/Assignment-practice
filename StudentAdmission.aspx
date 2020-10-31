﻿
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentAdmission.aspx.cs" Inherits="AspStudentAdmission.StudentAdmission" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 965px;
        }
        .auto-style2 {
            width: 965px;
            height: 18px;
        }
        .auto-style3 {
            height: 18px;
        }
        .auto-style4 {
            margin-left: 52px;
        }
        .auto-style5 {
            margin-left: 26px;
        }
        .auto-style7 {
            margin-left: 95px;
        }
        .auto-style8 {
            width: 965px;
            height: 44px;
        }
        .auto-style9 {
            height: 44px;
        }
        .auto-style10 {
            width: 965px;
            height: 26px;
        }
        .auto-style11 {
            height: 26px;
        }
        .auto-style12 {
            width: 965px;
            height: 17px;
        }
        .auto-style13 {
            height: 17px;
        }
        .auto-style14 {
            margin-left: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">FirstName:&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox1" runat="server" Width="246px" BackColor="Aqua"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Provide your firstname" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">LastName:<asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style4" Width="247px" BackColor="Aqua"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Provide your lastname" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox8" runat="server" BackColor="Aqua" Width="243px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox3" ErrorMessage="Provide your email" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter valid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Father&#39;s Name:<asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style5" Width="247px" BackColor="Aqua"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox6" ErrorMessage="Provide your fathers name" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;&nbsp;
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Mother&#39;s Name:<asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style14" Width="247px" BackColor="Aqua"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox7" ErrorMessage="Provide your mothers name" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">Gender:&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" BackColor="aqua" />
                        &nbsp;<asp:RadioButton ID="RadioButton2" runat="server" Text="Female" BackColor="aqua" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please select the gender" ForeColor="Red" ControlToValidate="TextBox8"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style8">Aggregate:&nbsp;&nbsp; Enter Aggregate Greater than 55<br />
                        <asp:TextBox ID="TextBox7" runat="server" CssClass="auto-style5" Width="247px" BackColor="Aqua"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox8" ErrorMessage="Enter valid aggregate" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style9"></td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;&nbsp;&nbsp;&nbsp;
                        
                        Courses:<br />
&nbsp;<asp:RadioButton ID="RadioButton3" runat="server" BackColor="aqua" Text="ECE" />
                        <br />
&nbsp;&nbsp;
                        <asp:CheckBox ID="CheckBox1" runat="server" BackColor="aqua" Text="Micro Controller" />
&nbsp;&nbsp;
                        <asp:CheckBox ID="CheckBox2" runat="server" BackColor="aqua" Text="Logic Design" />
&nbsp;&nbsp;
                        <asp:CheckBox ID="CheckBox3" runat="server" BackColor="aqua" Text="Analog Communications" />
                        <br />
                        <asp:RadioButton ID="RadioButton4" runat="server" BackColor="aqua" Text="CSE" />
                        <br />
&nbsp;&nbsp;
                        <asp:CheckBox ID="CheckBox4" runat="server" BackColor="aqua" Text="Computer Operating Architecture" />
&nbsp;
                        <asp:CheckBox ID="CheckBox5" runat="server" BackColor="Aqua" Text="Data structures" />
&nbsp;
                        <asp:CheckBox ID="CheckBox6" runat="server" BackColor="aqua" Text="Computer Networks" />
                    </td>
                    <td class="auto-style13"></td>
                    <td class="auto-style13"></td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" CssClass="auto-style7" Text="Register" Width="253px" BackColor="aqua" OnClick="Button1_Click" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="Blue" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
