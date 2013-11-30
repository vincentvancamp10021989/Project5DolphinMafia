<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminMain.aspx.cs" Inherits="WebApplication1.AdminMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Admin Pagina<br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:BoundField DataField="Start" HeaderText="Start" SortExpression="Start" />
                <asp:BoundField DataField="End" HeaderText="End" SortExpression="End" />
                <asp:BoundField DataField="Duration" HeaderText="Duration" SortExpression="Duration" />
                <asp:BoundField DataField="Available" HeaderText="Available" SortExpression="Available" />
                <asp:BoundField DataField="Capacity" HeaderText="Capacity" SortExpression="Capacity" />
                <asp:BoundField DataField="Digital" HeaderText="Digital" SortExpression="Digital" />
                <asp:BoundField DataField="Campus" HeaderText="Campus" SortExpression="Campus" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB_9ABFAC_Project5ConnectionString %>" SelectCommand="SELECT * FROM [Slots]"></asp:SqlDataSource>
        Verwijder slot (id):
        <asp:TextBox ID="txtboxID" runat="server" Width="46px"></asp:TextBox>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Verwijderen" />
        <br />
        <asp:Button ID="btnAddSlot" runat="server" OnClick="btnAddSlot_Click" Text="Slot Toevoegen" Width="171px" />
        <br />
        <asp:Button ID="btnAddCampus" runat="server" OnClick="btnAddCampus_Click" Text="Campus Toevoegen" />
        <br />
        Message of the day veranderen: <asp:TextBox ID="txtboxMOTD" runat="server" Width="292px"></asp:TextBox>
        <asp:Button ID="btnMOTDSend" runat="server" Text="Verzenden" />
        <br />
        <br />
        <asp:Button ID="BtnLogOut" runat="server" OnClick="BtnLogOut_Click" Text="Log Out" />
    </div>
    </form>
</body>
</html>