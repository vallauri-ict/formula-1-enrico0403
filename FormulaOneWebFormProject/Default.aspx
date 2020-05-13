<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormulaOneWebFormProject.Default" EnableEventValidation="False"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>        
        div{margin:10px}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnLoadCountry" runat="server" OnClick="btnLoadCountry_Click" Text="Carica countries" />
            <asp:Button ID="btnLoadTeam" runat="server" OnClick="btnLoadTeam_Click" Text="Carica teams" />
            <asp:Button ID="btnLoadDriver" runat="server" OnClick="btnLoadDriver_Click" Text="Carica drivers" />
            <asp:GridView ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
