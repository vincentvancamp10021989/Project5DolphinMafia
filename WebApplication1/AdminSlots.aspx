<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSlots.aspx.cs" Inherits="WebApplication1.AdminSlots" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 22px;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table>
        <tr>
            <td colspan="2" align="center">Add new Slot</td>
        </tr>
        <tr>
            <td>Date</td>
            <td>
                <asp:TextBox ID="txtboxDate" runat="server"></asp:TextBox>
                (dd/mm/yyyy)</td>
            
        </tr>
        <tr>
            <td>Start</td>
            <td>
                <asp:TextBox ID="txtboxStart" runat="server"></asp:TextBox>
                (hh:mm)</td>
         
        </tr>
        <tr>
            <td>End</td>
            <td>
                <asp:TextBox ID="txtboxEnd" runat="server"></asp:TextBox>
                (hh:mm)</td>
        
        </tr>
        <tr>
            <td class="auto-style1">Duration</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtboxDuration" runat="server"></asp:TextBox>
                (hh:mm)</td>

        </tr>
        <tr>
            <td>Capacity</td>
            <td>
                <asp:TextBox ID="txtboxCapacity" runat="server" OnTextChanged="txtboxCapacity_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Reserved</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtboxReserved" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Digital</td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Value="0" Selected="True">No</asp:ListItem>
                    <asp:ListItem Value="1">Yes</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>Campus</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="dsSlotsCampus" DataTextField="Plaats" DataValueField="Plaats" Height="16px">
                </asp:DropDownList>
                <asp:LinqDataSource ID="dsSlotsCampus" runat="server" ContextTypeName="WebApplication1.DataClasses1DataContext" EntityTypeName="" Select="new (key as Plaats, it as Campus)" TableName="Campus" GroupBy="Plaats">
                </asp:LinqDataSource>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnAddSlot" runat="server" Text="Add" Width="63px" OnClick="btnAddSlot_Click" />
            </td>
        </tr>



    </table>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
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
    </form>
</body>
</html>
