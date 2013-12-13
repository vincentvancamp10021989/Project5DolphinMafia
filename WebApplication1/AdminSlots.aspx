<link href="Opmaak.css" rel="stylesheet" type="text/css" />
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSlots.aspx.cs" Inherits="WebApplication1.AdminSlots" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    <title>AP Administrator SlotsManagement</title>
</head>

<body>
    <div class="banner"></div>
    <div class="content">
    <form id="form1" runat="server">
    <table>
        <tr>
            <td><h2>Slot Toevoegen:</h2></td>
            <td><asp:Label ID="errorLbl" runat="server" ForeColor="Red" Text="Er is iets fout gelopen..." Visible="False"></asp:Label></td>
                
        </tr>
        <tr>
            <td>Datum</td>
            <td><asp:TextBox ID="txtboxDate" runat="server"></asp:TextBox> (dd/mm/jjjj)</td>
            
        </tr>
        <tr>
            <td>Start</td>
            <td><asp:TextBox ID="txtboxStart" runat="server"></asp:TextBox> (uu:mm)</td>
         
        </tr>
        <tr>
            <td>Einde</td>
            <td><asp:TextBox ID="txtboxEnd" runat="server"></asp:TextBox> (uu:mm)</td>
        
        </tr>
        <tr>
            <td>Duur</td>
            <td><asp:TextBox ID="txtboxDuration" runat="server"></asp:TextBox> (uu:mm)</td>

        </tr>
        <tr>
            <td>Capaciteit</td>
            <td><asp:TextBox ID="txtboxCapacity" runat="server" OnTextChanged="txtboxCapacity_TextChanged"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Digitaal?</td>
            <td><asp:RadioButtonList ID="RadioButtonList1" runat="server"><asp:ListItem Value="0" Selected="True">Nee</asp:ListItem><asp:ListItem Value="1">Ja</asp:ListItem></asp:RadioButtonList></td>
        </tr>
        <tr>
            <td>Campus</td>
            <td><asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="dsSlotsCampus" DataTextField="Plaats" DataValueField="Plaats"
                CssClass="ddl"></asp:DropDownList>
                <asp:LinqDataSource ID="dsSlotsCampus" runat="server" ContextTypeName="WebApplication1.DataClasses1DataContext" EntityTypeName="" Select="new (key as Plaats, it as Campus)" TableName="Campus" GroupBy="Plaats">
                </asp:LinqDataSource></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnAddSlot" runat="server" Text="Toevoegen" OnClick="btnAddSlot_Click" /></td>
        </tr>
    </table>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" class="APTable">
            <HeaderStyle CssClass="APTableHeader" />
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
        <br />
        <asp:Button ID="terugBtn" runat="server" OnClick="terugBtn_Click" Text="Terug" />
    </form>
</div>
</body>
</html>
