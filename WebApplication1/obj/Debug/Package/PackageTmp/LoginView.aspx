<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginView.aspx.cs" Inherits="WebApplication1.LoginView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>AP Registratie</title>
</head>
<body>
    <div id="Logo"></div>
        <%--<asp:Image  ID="Logo" runat="server" ImageUrl="~/images/artesis.jpg" 
                    BorderStyle="None" width="370" />--%>


<h2>Opgelet! De paswoorden van de vorige zit zijn niet meer geldig, gelieve een nieuw aan te vragen.</h2>

<form id="form1" runat="server">
        <asp:Label ID="ErrorLabel" runat="server" Text="Verkeerd e-mail adres. Gelieve opnieuw te proberen"></asp:Label>

<br />
        
<table>
    <tr>
        <td><asp:Label ID="labelUsername" runat="server" Text="Gebruikersnaam"></asp:Label></td>
        <td><asp:TextBox ID="textboxUsername" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="labelPassword" runat="server" Text="Paswoord"></asp:Label></td>
        <td><asp:TextBox ID="textboxPassword" runat="server" TextMode="Password"></asp:TextBox></td>
    </tr>
</table>
      
<table>
    <tr>
        <td><asp:Button ID="buttonLogin" runat="server" OnClick="buttonLogin_Click" Text="Login" Width="71px" /></td>
        <td><asp:Button ID="registrerenButton" runat="server" Text="Registreer" OnClick="registrerenButton_Click" /></td>
    </tr>
</table>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Project5ConnectionString %>" SelectCommand="SELECT Id, username, password_md5, email, access, first_name, last_name FROM Login"></asp:SqlDataSource>
    <br />
    <asp:Label ID="MoDLabel" runat="server" Text="Label"></asp:Label>



<h3>Nog geen paswoord of paswoord vergeten? Vul uw email adres in en klik op 'Versturen'.</h3>
<br />
        
<table>
    <tr>
        <td><asp:Label ID="mailAdressLabel" runat="server" Text="Mailadres"></asp:Label></td>
        <td><asp:TextBox ID="txtBoxMail" runat="server"></asp:TextBox></td>
    </tr>
</table>

<br />
<asp:Button ID="buttonSend" runat="server" Text="Versturen" OnClick="buttonSend_Click" />

</form>
</body>
</html>
