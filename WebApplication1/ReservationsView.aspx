<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservationsView.aspx.cs" Inherits="WebApplication1.ReservationsView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 63px;
        }
        .auto-style5 {
            width: 225px;
        }
        .auto-style6 {
            width: 52px;
        }
        .auto-style8 {
            width: 101px;
        }
        .auto-style9 {
            width: 37px;
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
<table>
  <tr>
    <th class="auto-style6">Datum</th>
    <th class="auto-style5">Begin</th>
    <th class="auto-style9">Einde</th>
    <th class="auto-style8">Duur</th>
    <th class="auto-style6">Digitaal</th>
    <th class="auto-style1">Locatie</th>
    <th></th>
  </tr>
    </table>
        <asp:Table ID="Table1" runat="server" Height="46px" Width="577px">
        </asp:Table>
        <asp:Panel ID="Panel1" runat="server" style="margin-left: 632px" Width="57px">
        </asp:Panel>
    </form>
</body>
</html>
