<link href="Opmaak.css" rel="stylesheet" type="text/css" />
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserChangePass.aspx.cs" Inherits="WebApplication1.UserChangePass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 28px;
        }
    </style>
</head>
<body>
    <div class="banner"></div>
    <div class="content">
    <form id="form1" runat="server">
    <div>
        <div class="tableTop">
        <table border="0">
<tr>
<td> 
    
        <asp:Label ID="lblOld" runat="server" Text="Oud Paswoord:"></asp:Label>
    </td>
<td><asp:TextBox ID="tbOld" runat="server" TextMode="Password"></asp:TextBox>
        </td>
</tr>
<tr>
<td class="auto-style1">
        <asp:Label ID="lblNew1" runat="server" Text="Nieuw Paswoord:"></asp:Label>
    </td>
<td class="auto-style1"><asp:TextBox ID="tbNew1" runat="server" TextMode="Password"></asp:TextBox>
        </td>
</tr>
<tr>
<td class="auto-style1">
        <asp:Label ID="lblNew2" runat="server" Text="Nieuw Paswoord Herhalen:"></asp:Label>
    </td>
    <td class="auto-style1"><asp:TextBox ID="tbNew2" runat="server" TextMode="Password"></asp:TextBox>
    
    </td>
</tr>
            <tr>
                <td> 
    
        <asp:Button ID="btnSend" runat="server" Text="Verzenden" OnClick="btnSend_Click" />
                </td>
            </tr>
</table> 
            </div>
    
        <h3><asp:Label ID="lblerror" runat="server"></asp:Label></h3>
        <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Terug" />
        <br />
    
    </div>
    </form>
        </div>
</body>
</html>
