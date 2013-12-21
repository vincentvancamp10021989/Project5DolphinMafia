<link href="Opmaak.css" rel="stylesheet" type="text/css" />
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationView.aspx.cs" Inherits="WebApplication1.RegistrationView" %>

<!DOCTYPE html>

<head>
    <title>AP Registratie</title>
</head>


<body>
    <div class="banner"></div>
    <div class="content">

    <form id="form1" runat="server">
    <table>
<tbody>

<tr>
<td>Voornaam: </td>
<td class="auto-style1"><asp:TextBox ID="textBoxNaam" runat="server"></asp:TextBox>
    </td>
</tr>

 <tr>
<td>Achternaam: </td>
<td class="auto-style1"><asp:TextBox ID="textBoxAchternaam" runat="server"></asp:TextBox>
     </td>
</tr>

<tr>
<td>Email: </td>
<td class="auto-style1">
    <asp:TextBox ID="textBoxEmail" runat="server"></asp:TextBox>
    <asp:Label ID="LabelAtAp" runat="server" Text="@ap.be"></asp:Label>
    </td>
</tr>



<tr>
<td>Wachtwoord:</td>
<td class="auto-style1">
    <asp:TextBox ID="textBoxPasswoord" runat="server" TextMode="Password"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>Wachtwoord herhalen:</td>
    <td class="auto-style1">
        <asp:TextBox ID="textBoxpwdherh" runat="server" TextMode="Password"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        <asp:Label ID="errorLabel" runat="server" Font-Bold="True" ForeColor="Red" Text="Uw passwoord komt niet overeen" Visible="False"></asp:Label>
    </td>
</tr>
<tr>
<td>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Verzenden" />
    </td>
</tr>



</tbody></table>
    </form>
        </div>
</body>

