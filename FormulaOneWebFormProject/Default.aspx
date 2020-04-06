<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormulaOneWebFormProject.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnLoadCountries" runat="server" OnClick="btnLoadData_Click" Text="CARICA NAZIONI" />
            <asp:Button ID="btnLoadDrivers" runat="server" OnClick="btnLoadDrivers_Click" Text="CARICA PILOTI" />
            <asp:Button ID="btnLoadTeams" runat="server" Text="CARICA SQUADRE" OnClick="btnLoadTeams_Click" />
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
            <asp:GridView ID="gwVisDati" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
