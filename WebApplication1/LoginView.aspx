<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginView.aspx.cs" Inherits="WebApplication1.LoginView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
         <asp:Image  ID="Logo" runat="server" ImageUrl="~/images/artesis.jpg" 
                    BorderStyle="None" width="370" />


<span style="color:red"><h3>Opgelet! De paswoorden van de vorige zit zijn niet meer geldig, gelieve een nieuw aan te vragen.</h3></span>
<br />
<span style="color:red">Verkeerd e-mail adres. Gelieve opnieuw te proberen.</span>
<br />
<br />

    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="labelUsername" runat="server" Text="username:"></asp:Label>
        <asp:TextBox ID="textboxUsername" runat="server" style="margin-left: 46px" Width="223px"></asp:TextBox>
        <p>
            <asp:Label ID="labelPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="textboxPassword" runat="server" style="margin-left: 45px" Width="219px"></asp:TextBox>
        </p>
        <asp:Button ID="buttonLogin" runat="server" OnClick="buttonLogin_Click" style="margin-left: 108px" Text="Login" Width="71px" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Project5ConnectionString %>" SelectCommand="SELECT Id, username, password_md5, email, access, first_name, last_name FROM Login"></asp:SqlDataSource>
        <p style="margin-left: 160px">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>


    <br />
<br />
<br />

    <h3>Nog geen paswoord of paswoord vergeten?
Vul uw email adres in en klik op 'Versturen'.</h3>
<br />
        <asp:Label ID="mailAdressLabel" runat="server" Text="Mailadress:"></asp:Label>
        <asp:TextBox ID="txtBoxMail" runat="server" style="margin-left: 36px" Width="227px"></asp:TextBox>
<br />


        <p>
            <asp:Button ID="buttonSend" runat="server" style="margin-left: 108px" Text="Versturen" Width="76px" OnClick="buttonSend_Click" />
        </p>
    </form>


    </body>
</html>
