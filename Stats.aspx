<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Stats.aspx.cs" Inherits="UnitConverterApp.Stats" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Conversion Statistics</title>
</head>
<body style="background-color: lavender;">
    <form id="form1" runat="server">
        <h2>Conversion Type Usage</h2>
        <asp:GridView ID="GridViewStats" runat="server" AutoGenerateColumns="true" />
    </form>
</body>
</html>
