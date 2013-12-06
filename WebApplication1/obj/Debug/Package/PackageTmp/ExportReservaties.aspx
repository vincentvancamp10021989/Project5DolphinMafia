<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExportReservaties.aspx.cs" Inherits="WebApplication1.ExportReservaties" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="BtnExport" runat="server" OnClick="BtnExport_Click" Text="Export" />
    
    </div>
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
    </form>
</body>
</html>
