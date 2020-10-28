<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationFormm.aspx.cs" Inherits="WebFormRegistration.RegistrationFormm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="Username" runat="server" style="margin-left: 117px" Width="212px" ></asp:TextBox><br />
            <asp:Label ID="label2" runat="server" Text="EmailAddress"></asp:Label>
            <asp:TextBox ID="EmailAddress" runat="server" style="margin-left: 94px" Width="211px"></asp:TextBox><br />
            <asp:Label ID="label3" runat="server"  Text="password"></asp:Label>
            <asp:TextBox ID="Password" runat="server" TextMode="Password" style="margin-left: 119px" Width="210px"></asp:TextBox><br />
            <asp:Label ID="labell4" runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox ID="textbox4" runat="server" TextMode="Password" style="margin-left: 64px" Width="210px"></asp:TextBox><br />
            <asp:Label ID="label5" runat="server" Text="Gender"></asp:Label><br />
            <asp:RadioButton ID="radiobutton1" GroupName="gender" runat="server" Text="male" />
            <asp:RadioButton ID="radiobutton2" GroupName="gender" runat="server" Text="female" /><br />
            <asp:Label ID="showccourses" runat="server"></asp:Label>
            <br />
            <asp:CheckBox ID="checkbox1" runat="server" Text="java" />
            <asp:CheckBox ID="checkbox2" runat="server" Text="Python" />
            <asp:CheckBox ID="checkbox3" runat="server" Text="Asp.Net" />
            <asp:CheckBox ID="checkbox4" runat="server" Text="SpringBoot" />
            <asp:CheckBox ID="checkbox5" runat="server" Text="csharp" />
            <asp:CheckBox ID="checkbox6" runat="server" Text="c" />
            <asp:CheckBox ID="checkbox7" runat="server" Text="Mysql" /><br /><br />
            <asp:Button ID="button1" runat="server" Text="Registration/Signup" OnClick="button1_Click" style="margin-left: 117px" /><br />
            <asp:Label ID="message" runat="server"></asp:Label><br />
            
            <asp:Label  ID="showusername" runat="server"></asp:Label>   <br />        
            <asp:Label  ID="showemailadress" runat="server"></asp:Label><br />
            <asp:Label  ID="showgender" runat="server"></asp:Label><br />
            <asp:Label  ID="showcourses" runat="server"></asp:Label><br />
            <asp:Label  ID="showusernamelabel" runat="server"></asp:Label>           
            <asp:Label  ID="showemailaddresslabel" runat="server"></asp:Label>
            <asp:Label  ID="showgenderlabel" runat="server"></asp:Label>
            <asp:Label  ID="showcourseslabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
