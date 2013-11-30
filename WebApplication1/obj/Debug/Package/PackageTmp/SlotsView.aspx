﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SlotsView.aspx.cs" Inherits="WebApplication1.SlotsView" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Examonitor</title>
    </head>
<body>
    <form id="form1" runat="server">
    <asp:Image  ID="Logo" runat="server" ImageUrl="~/images/artesis.jpg" 
                    BorderStyle="None" width="370" />

    <h2>Toezichtsbeurten BLS</h2>
<br />
<br />
Toezichtsbeurten voor :  Antwerpen
<br />
<br />
<a href="/ReservationsView.aspx">Mijn reservaties</a>
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
    <th class="auto-style39">Capaciteit</th>
    <th class="auto-style1">Beschikbaar</th>
    <th class="auto-style1">Locatie</th>
     <th class="auto-style1">Digitaal</th>
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
        <td class="auto-style38"><asp:Table ID="tableCapaciteit" runat="server">
        </asp:Table></td>
         <td class="auto-style40"><asp:Table ID="tableBeschikbaar" runat="server">
        </asp:Table></td>
        <td class="auto-style17"><asp:Table ID="tableLocatie" runat="server">
        </asp:Table></td>
        <td class="auto-style40"><asp:Table ID="tableDigitaal" runat="server">
        </asp:Table></td>
        
        
        <td class="auto-style19"><asp:Panel ID="Panel1" runat="server" style="margin-left: auto" Width="80px">
        </asp:Panel></td>
    </tr>
    </table>
   

<br />
<br />

    </form>

</body>
</html>