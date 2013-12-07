<link href="Opmaak.css" rel="stylesheet" type="text/css" />
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservationsView.aspx.cs" Inherits="WebApplication1.ReservationsView" %>

<head>
    <title>AP Registratie</title>
</head>


<body>
    <div class="banner"></div>
    <div class="content">

    <form id="form1" runat="server">

    <h2>Mijn reservaties</h2>
<br />

 <asp:Button ID="btnTerug" runat="server" OnClick="btnTerug_Click" Text="Terug naar overzicht" />
<br />
<br />
<br />
        <div class="tableTop">
<table>
    <thead>
  <tr>
    <th>Datum</th>
    <th>Begin</th>
    <th>Einde</th>
    <th>Duur</th>
    <th>Digitaal</th>
    <th>Locatie</th>
  </tr>
        </thead>
    <tr>
        <td><asp:Table ID="tableDatum" runat="server">
        </asp:Table></td>
        <td><asp:Table ID="tableBegin" runat="server">
        </asp:Table></td>
        <td><asp:Table ID="tableEind" runat="server">
        </asp:Table></td>
        <td><asp:Table ID="tableDuur" runat="server">
        </asp:Table></td>
        <td><asp:Table ID="tableDigitaal" runat="server">
        </asp:Table></td>
        <td><asp:Table ID="tableLocatie" runat="server">
        </asp:Table></td>
        <td><asp:Panel ID="Panel1" runat="server" style="margin-left: auto" Width="80px">
        </asp:Panel></td>
    </tr>
    </table>
            </div>
    </form>
</div>
</body>
