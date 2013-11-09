<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservationsView.aspx.cs" Inherits="WebApplication1.ReservationsView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    <th>Datum</th>
    <th>Begin</th>
    <th>Einde</th>
    <th>Duur</th>
    <th>Digitaal</th>
    <th>Locatie</th>
    <th></th>
  </tr>
    </table>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnLoad="GridView1_Load" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Slot_id" HeaderText="Slot_id" SortExpression="Slot_id" />
                <asp:BoundField DataField="Lecturer_id" HeaderText="Lecturer_id" SortExpression="Lecturer_id" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB_9ABFAC_Project5ConnectionString %>" SelectCommand="SELECT * FROM [Reservations]"></asp:SqlDataSource>
    </form>
</body>
</html>
