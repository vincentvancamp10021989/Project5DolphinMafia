<link href="Opmaak.css" rel="stylesheet" type="text/css" />
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SlotsView.aspx.cs" Inherits="WebApplication1.SlotsView" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    <title>AP Slots</title>
</head>


<body>
    <div class="banner"></div>
    <div class="content">
    <form id="form1" runat="server">


        <h2>Toezichtsbeurten BLS<asp:Button ID="BtnPassword" runat="server" OnClick="BtnPassword_Click" Text="wijzig password" />
        </h2>
        <asp:DropDownList ID="dropDownListCampus" runat="server" DataSourceID="UniekCampus" DataTextField="Plaats" DataValueField="Plaats">
        </asp:DropDownList>
        <asp:SqlDataSource ID="UniekCampus" runat="server" ConnectionString="<%$ ConnectionStrings:DB_9ABFAC_Project5ConnectionString %>" SelectCommand="SELECT [Plaats] FROM [Campus]"></asp:SqlDataSource>
        <asp:Button ID="buttonKies" runat="server" Text="Kies" OnClick="buttonKies_Click" />

<h3>Toezichtsbeurten voor :  Antwerpen</h3>
<br />

        <asp:Button ID="btnReservations" runat="server" OnClick="btnReservations_Click" Text="Mijn reservaties" />

<br />
<div class="tableTop">
<table>
    <thread>
  <tr>
    <th>Datum</th>
    <th>Begin</th>
    <th>Einde</th>
    <th>Duur</th>
    <th>Capaciteit</th>
    <th>Beschikbaar</th>
    <th>Locatie</th>
    <th>Digitaal</th>
  </tr>
    </thread>
  <tr>
        <td><asp:Table ID="tableDatum" runat="server">
        </asp:Table></td>
        <td><asp:Table ID="tableBegin" runat="server">
        </asp:Table></td>
        <td><asp:Table ID="tableEind" runat="server">
        </asp:Table></td>
        <td><asp:Table ID="tableDuur" runat="server" >
        </asp:Table></td>
        <td><asp:Table ID="tableCapaciteit" runat="server">
        </asp:Table></td>
         <td><asp:Table ID="tableBeschikbaar" runat="server">
        </asp:Table></td>
        <td><asp:Table ID="tableLocatie" runat="server" >
        </asp:Table></td>
        <td><asp:Table ID="tableDigitaal" runat="server">
        </asp:Table></td>
        <td><asp:Panel ID="Panel1" runat="server" style="margin-left: auto" Width="80px">
        </asp:Panel></td>
    </tr>
    </table>
    </div>

<asp:Button ID="buttonLogout" runat="server" Text="Logout" OnClick="Button1_Click"/>

    </form>
        </div>

</body>
</html>
