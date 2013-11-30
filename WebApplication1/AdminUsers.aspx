<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminUsers.aspx.cs" Inherits="WebApplication1.AdminUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 60px;
        }
        .auto-style2 {
            width: 70px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td colspan="2" align="center">Update User</td>
        </tr>
        <tr>
            <td class="auto-style2">Firstname</td>
            <td>
                <asp:TextBox ID="txtboxFirstname" runat="server"></asp:TextBox>
                </td>
            
        </tr>
        <tr>
            <td class="auto-style2">Lastname</td>
            <td>
                <asp:TextBox ID="txtboxLastname" runat="server"></asp:TextBox>
                </td>
         
        </tr>
        <tr>
            <td class="auto-style2">Email</td>
            <td>
                <asp:TextBox ID="txtboxEMail" runat="server"></asp:TextBox>
                </td>
        
        </tr>
        <tr>
            <td class="auto-style2">Access</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtboxAccess" runat="server"></asp:TextBox>
                </td>

        </tr>
        <tr>
            <td class="auto-style2">Password</td>
            <td>
                <asp:TextBox ID="txtboxPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">

                <asp:Button ID="BtnAddUser" runat="server" Text="Add User" />

            </td>
        </tr>
    </table>
        </div>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="Lecturers">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Firstname" HeaderText="Firstname" SortExpression="Firstname" />
                <asp:BoundField DataField="Lastname" HeaderText="Lastname" SortExpression="Lastname" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Access" HeaderText="Access" SortExpression="Access" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="Lecturers" runat="server" ConnectionString="<%$ ConnectionStrings:DB_9ABFAC_Project5ConnectionString %>" SelectCommand="SELECT * FROM [Lecturers]"></asp:SqlDataSource>
    
        <p>
            <asp:Button ID="BtnTerug" runat="server" OnClick="BtnTerug_Click" Text="Terug" />
            <br />
        </p>
    </form>
    </form>
</body>
</html>
