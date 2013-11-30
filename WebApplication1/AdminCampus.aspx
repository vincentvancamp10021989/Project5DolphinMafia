﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminCampus.aspx.cs" Inherits="WebApplication1.AdminCampus" %>
<link rel="stylesheet" type="text/css" href="opmaak.css">
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    <title>AP Registratie</title>
</head>


<body>
    <div class="banner"></div>
    <div class="content">

    <form id="form1" runat="server">
    <div>
         <p>Niewe campus toevoegen:</p>
     <table>
        <tr>
            <td>Locatie:</td>
            <td>
                <asp:TextBox ID="txtboxCampusPlaats" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnCampus" runat="server" Text="Toevoegen" OnClick="btnCampus_Click" />
            </td>
        </tr>



    </table>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSourceCampus">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Plaats" HeaderText="Plaats" SortExpression="Plaats" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceCampus" runat="server" ConnectionString="<%$ ConnectionStrings:DB_9ABFAC_Project5ConnectionString %>" SelectCommand="SELECT * FROM [Campus]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB_9ABFAC_Project5ConnectionString %>" SelectCommand="SELECT * FROM [Campus]"></asp:SqlDataSource>
    </div>
    </form>
    </div>
</body>
</html>

