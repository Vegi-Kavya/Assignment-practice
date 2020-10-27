<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkButton.aspx.cs" Inherits="LinkButton.LinkButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                <h3>Hyper Link Button</h3>
        <div>
            Name:<asp:TextBox id="textbox1" runat="server" OnTextChanged="TextBox1_TextChanged" /><br />
            <asp:LinkButton id="Button1" Text="Submit" PostBackUrl="demo_postbackurl.aspx" runat="Server" OnClick="Button1_Click" /><br />
            <asp:LinkButton  runat="server" ID="linkButton1" OnClick="Linkbutton1_Click" OnCommand="Command Event Handler" 
                OnDataBinding="DataBinding Event Handler"  OnInit="Init event Handler" OnLoad="load Event Handler" 
                OnPreRender="On PreRender event Handler" OnUnload="Unload event Handler" PostBackUrl="uri" > Facebook </asp:LinkButton><br/><br/>
            <asp:LinkButton ID="linkButton2" runat="server" OnClick="Linkbutton1_Click" >Youtube</asp:LinkButton><br/><br/>
            <asp:LinkButton ID="linkButton3" runat="server" OnClick="Linkbutton1_Click" >Instagram</asp:LinkButton><br/><br/>
            <asp:LinkButton ID="linkButton4" runat="server" OnClick="Linkbutton1_Click">hike</asp:LinkButton><br/><br/>
            <asp:LinkButton ID="linkButton5" runat="server" OnClick="Linkbutton1_Click" >Telegram</asp:LinkButton><br/><br/>
        </div>
        <p>
            <asp:Label ID="Hello" runat="server"/>
        </p>
    </form>

</body>
</html>
