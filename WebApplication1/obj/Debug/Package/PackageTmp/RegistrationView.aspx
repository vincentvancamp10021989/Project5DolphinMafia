<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationView.aspx.cs" Inherits="WebApplication1.RegistrationView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Registratie</title>
    <style type="text/css">
        .auto-style1 {
            width: 132px;
        }
    </style>
</head>
<body>
    <asp:Image  ID="Logo" runat="server" ImageUrl="~/images/artesis.jpg" 
                    BorderStyle="None" width="370" />


<br />
<br />
<br />
    <form id="form1" runat="server">
    <table border="0">
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
    <td>
        <asp:TextBox ID="textBoxpwdherh" runat="server" TextMode="Password"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        <asp:Label ID="errorLabel" runat="server" Font-Bold="True" ForeColor="Red" Text="Uw passwoord komt niet overeen" Visible="False"></asp:Label>
    </td>
</tr>
<tr>
<td align="right">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Verzenden" />
    </td>
</tr>



</tbody></table>
    </form>
</body>
</html>

