<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservationsView.aspx.cs" Inherits="WebApplication1.ReservationsView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 76px;
        }
        .auto-style17 {
            width: 76px;
            height: 164px;
        }
        .auto-style19 {
            height: 164px;
        }
        .auto-style35 {
            width: 90px;
        }
        .auto-style36 {
            width: 90px;
            height: 164px;
        }
        .auto-style37 {
            width: 86px;
        }
        .auto-style38 {
            width: 86px;
            height: 164px;
        }
        .auto-style39 {
            width: 75px;
        }
        .auto-style40 {
            width: 75px;
            height: 164px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
<asp:Image  ID="Logo" runat="server" ImageUrl="~/images/artesis.jpg" 
                    BorderStyle="None" width="370" />

    <h2>Mijn reservaties</h2>
<br />

<br />
<br />
<br />
<a href="/SlotsView.aspx">Terug naar overzicht</a>
<br />
<br />
<br />
<table border ="1" style="margin:0px auto; width:500px">
    <thead>
  <tr>
    <th class="auto-style35">Datum</th>
    <th class="auto-style37">Begin</th>
    <th class="auto-style35">Einde</th>
    <th class="auto-style37">Duur</th>
    <th class="auto-style39">Digitaal</th>
    <th class="auto-style1">Locatie</th>
  </tr>
        </thead>
    <tr>
        <td class="auto-style36"><asp:Table ID="tableDatum" runat="server">
        </asp:Table></td>
        <td class="auto-style38"><asp:Table ID="tableBegin" runat="server">
        </asp:Table></td>
        <td class="auto-style36"><asp:Table ID="tableEind" runat="server">
        </asp:Table></td>
        <td class="auto-style38"><asp:Table ID="tableDuur" runat="server">
        </asp:Table></td>
        <td class="auto-style40"><asp:Table ID="tableDigitaal" runat="server">
        </asp:Table></td>
        <td class="auto-style17"><asp:Table ID="tableLocatie" runat="server">
        </asp:Table></td>
        <td class="auto-style19"><asp:Panel ID="Panel1" runat="server" style="margin-left: auto" Width="80px">
        </asp:Panel></td>
    </tr>
    </table>
    </form>
</body>
</html>
