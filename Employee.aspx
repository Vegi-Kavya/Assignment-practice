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
            <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource2">
                <AlternatingItemTemplate>
                    <li style="background-color: #FAFAD2;color: #284775;">EmpID:
                        <asp:Label ID="EmpIDLabel" runat="server" Text='<%# Eval("EmpID") %>' />
                        <br />
                        EmpName:
                        <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Eval("EmpName") %>' />
                        <br />
                        EmpEmailID:
                        <asp:Label ID="EmpEmailIDLabel" runat="server" Text='<%# Eval("EmpEmailID") %>' />
                        <br />
                        EmpMobileNum:
                        <asp:Label ID="EmpMobileNumLabel" runat="server" Text='<%# Eval("EmpMobileNum") %>' />
                        <br />
                        EmpImage:
                        <asp:Label ID="EmpImageLabel" runat="server" Text='<%# Eval("EmpImage") %>' />
                        <br />
                        EmpGender:
                        <asp:Label ID="EmpGenderLabel" runat="server" Text='<%# Eval("EmpGender") %>' />
                        <br />
                    </li>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <li style="background-color: #FFCC66;color: #000080;">EmpID:
                        <asp:TextBox ID="EmpIDTextBox" runat="server" Text='<%# Bind("EmpID") %>' />
                        <br />
                        EmpName:
                        <asp:TextBox ID="EmpNameTextBox" runat="server" Text='<%# Bind("EmpName") %>' />
                        <br />
                        EmpEmailID:
                        <asp:TextBox ID="EmpEmailIDTextBox" runat="server" Text='<%# Bind("EmpEmailID") %>' />
                        <br />
                        EmpMobileNum:
                        <asp:TextBox ID="EmpMobileNumTextBox" runat="server" Text='<%# Bind("EmpMobileNum") %>' />
                        <br />
                        EmpImage:
                        <asp:TextBox ID="EmpImageTextBox" runat="server" Text='<%# Bind("EmpImage") %>' />
                        <br />
                        EmpGender:
                        <asp:TextBox ID="EmpGenderTextBox" runat="server" Text='<%# Bind("EmpGender") %>' />
                        <br />
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </li>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    No data was returned.
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <li style="">EmpID:
                        <asp:TextBox ID="EmpIDTextBox" runat="server" Text='<%# Bind("EmpID") %>' />
                        <br />EmpName:
                        <asp:TextBox ID="EmpNameTextBox" runat="server" Text='<%# Bind("EmpName") %>' />
                        <br />EmpEmailID:
                        <asp:TextBox ID="EmpEmailIDTextBox" runat="server" Text='<%# Bind("EmpEmailID") %>' />
                        <br />EmpMobileNum:
                        <asp:TextBox ID="EmpMobileNumTextBox" runat="server" Text='<%# Bind("EmpMobileNum") %>' />
                        <br />EmpImage:
                        <asp:TextBox ID="EmpImageTextBox" runat="server" Text='<%# Bind("EmpImage") %>' />
                        <br />EmpGender:
                        <asp:TextBox ID="EmpGenderTextBox" runat="server" Text='<%# Bind("EmpGender") %>' />
                        <br />
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </li>
                </InsertItemTemplate>
                <ItemSeparatorTemplate>
<br />
                </ItemSeparatorTemplate>
                <ItemTemplate>
                    <li style="background-color: #FFFBD6;color: #333333;">EmpID:
                        <asp:Label ID="EmpIDLabel" runat="server" Text='<%# Eval("EmpID") %>' />
                        <br />
                        EmpName:
                        <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Eval("EmpName") %>' />
                        <br />
                        EmpEmailID:
                        <asp:Label ID="EmpEmailIDLabel" runat="server" Text='<%# Eval("EmpEmailID") %>' />
                        <br />
                        EmpMobileNum:
                        <asp:Label ID="EmpMobileNumLabel" runat="server" Text='<%# Eval("EmpMobileNum") %>' />
                        <br />
                        EmpImage:
                        <asp:Label ID="EmpImageLabel" runat="server" Text='<%# Eval("EmpImage") %>' />
                        <br />
                        EmpGender:
                        <asp:Label ID="EmpGenderLabel" runat="server" Text='<%# Eval("EmpGender") %>' />
                        <br />
                    </li>
                </ItemTemplate>
                <LayoutTemplate>
                    <ul id="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                        <li runat="server" id="itemPlaceholder" />
                    </ul>
                    <div style="text-align: center;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;">
                    </div>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <li style="background-color: #FFCC66;font-weight: bold;color: #000080;">EmpID:
                        <asp:Label ID="EmpIDLabel" runat="server" Text='<%# Eval("EmpID") %>' />
                        <br />
                        EmpName:
                        <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Eval("EmpName") %>' />
                        <br />
                        EmpEmailID:
                        <asp:Label ID="EmpEmailIDLabel" runat="server" Text='<%# Eval("EmpEmailID") %>' />
                        <br />
                        EmpMobileNum:
                        <asp:Label ID="EmpMobileNumLabel" runat="server" Text='<%# Eval("EmpMobileNum") %>' />
                        <br />
                        EmpImage:
                        <asp:Label ID="EmpImageLabel" runat="server" Text='<%# Eval("EmpImage") %>' />
                        <br />
                        EmpGender:
                        <asp:Label ID="EmpGenderLabel" runat="server" Text='<%# Eval("EmpGender") %>' />
                        <br />
                    </li>
                </SelectedItemTemplate>
            </asp:ListView>
            <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource2">
                <ItemTemplate>
                    EmpID:
                    <asp:Label ID="EmpIDLabel" runat="server" Text='<%# Eval("EmpID") %>' />
                    <br />
                    EmpName:
                    <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Eval("EmpName") %>' />
                    <br />
                    EmpEmailID:
                    <asp:Label ID="EmpEmailIDLabel" runat="server" Text='<%# Eval("EmpEmailID") %>' />
                    <br />
                    EmpMobileNum:
                    <asp:Label ID="EmpMobileNumLabel" runat="server" Text='<%# Eval("EmpMobileNum") %>' />
                    <br />
                    EmpImage:
                    <asp:Label ID="EmpImageLabel" runat="server" Text='<%# Eval("EmpImage") %>' />
                    <br />
                    EmpGender:
                    <asp:Label ID="EmpGenderLabel" runat="server" Text='<%# Eval("EmpGender") %>' />
                    <br />
<br />
                </ItemTemplate>
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [EmployeeTable]"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="EmpID" HeaderText="EmpID" SortExpression="EmpID" />
                    <asp:BoundField DataField="EmpName" HeaderText="EmpName" SortExpression="EmpName" />
                    <asp:BoundField DataField="EmpEmailID" HeaderText="EmpEmailID" SortExpression="EmpEmailID" />
                    <asp:BoundField DataField="EmpMobileNum" HeaderText="EmpMobileNum" SortExpression="EmpMobileNum" />
                    <asp:BoundField DataField="EmpImage" HeaderText="EmpImage" SortExpression="EmpImage" />
                    <asp:BoundField DataField="EmpGender" HeaderText="EmpGender" SortExpression="EmpGender" />
                </Columns>
            </asp:GridView>
        </div>       
        <asp:FormView ID="FormView1" runat="server" DataSourceID="SqlDataSource2" AllowPaging="True">
            <EditItemTemplate>
                EmpID:
                <asp:TextBox ID="EmpIDTextBox" runat="server" Text='<%# Bind("EmpID") %>' />
                <br />
                EmpName:
                <asp:TextBox ID="EmpNameTextBox" runat="server" Text='<%# Bind("EmpName") %>' />
                <br />
                EmpEmailID:
                <asp:TextBox ID="EmpEmailIDTextBox" runat="server" Text='<%# Bind("EmpEmailID") %>' />
                <br />
                EmpMobileNum:
                <asp:TextBox ID="EmpMobileNumTextBox" runat="server" Text='<%# Bind("EmpMobileNum") %>' />
                <br />
                EmpImage:
                <asp:TextBox ID="EmpImageTextBox" runat="server" Text='<%# Bind("EmpImage") %>' />
                <br />
                EmpGender:
                <asp:TextBox ID="EmpGenderTextBox" runat="server" Text='<%# Bind("EmpGender") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                EmpID:
                <asp:TextBox ID="EmpIDTextBox" runat="server" Text='<%# Bind("EmpID") %>' />
                <br />
                EmpName:
                <asp:TextBox ID="EmpNameTextBox" runat="server" Text='<%# Bind("EmpName") %>' />
                <br />
                EmpEmailID:
                <asp:TextBox ID="EmpEmailIDTextBox" runat="server" Text='<%# Bind("EmpEmailID") %>' />
                <br />
                EmpMobileNum:
                <asp:TextBox ID="EmpMobileNumTextBox" runat="server" Text='<%# Bind("EmpMobileNum") %>' />
                <br />
                EmpImage:
                <asp:TextBox ID="EmpImageTextBox" runat="server" Text='<%# Bind("EmpImage") %>' />
                <br />
                EmpGender:
                <asp:TextBox ID="EmpGenderTextBox" runat="server" Text='<%# Bind("EmpGender") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                EmpID:
                <asp:Label ID="EmpIDLabel" runat="server" Text='<%# Bind("EmpID") %>' />
                <br />
                EmpName:
                <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Bind("EmpName") %>' />
                <br />
                EmpEmailID:
                <asp:Label ID="EmpEmailIDLabel" runat="server" Text='<%# Bind("EmpEmailID") %>' />
                <br />
                EmpMobileNum:
                <asp:Label ID="EmpMobileNumLabel" runat="server" Text='<%# Bind("EmpMobileNum") %>' />
                <br />
                EmpImage:
                <asp:Label ID="EmpImageLabel" runat="server" Text='<%# Bind("EmpImage") %>' />
                <br />
                EmpGender:
                <asp:Label ID="EmpGenderLabel" runat="server" Text='<%# Bind("EmpGender") %>' />
                <br />

            </ItemTemplate>
        </asp:FormView>
    </form>
</body>
</html>
