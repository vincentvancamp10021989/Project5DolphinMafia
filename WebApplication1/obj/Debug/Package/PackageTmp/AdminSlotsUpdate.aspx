<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSlotsUpdate.aspx.cs" Inherits="WebApplication1.AdminSlotsUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
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
            <td colspan="2" align="center">Update Slot</td>
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
                <asp:TextBox ID="txtboxCapacity" runat="server"></asp:TextBox>
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
                <asp:LinqDataSource ID="dsSlotsCampus" runat="server" ContextTypeName="WebApplication1.DatabaseDataClassesDataContext" EntityTypeName="" Select="new (Plaats)" TableName="tblCampus">
                </asp:LinqDataSource>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnUpdateSlots" runat="server" Text="Update" Width="63px" OnClick="btnAddSlot_Click" />
            </td>
        </tr>



    </table>
    </form>
</body>
</html>

