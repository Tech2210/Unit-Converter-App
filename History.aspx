<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="UnitConverterApp.History" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Conversion History</title>
</head>
<body style="background-color: skyblue;">
    <form id="form1" runat="server">
        <h2>Conversion History</h2>

        <div>
            <asp:Label ID="lblType" runat="server" Text="Conversion Type: " />
            <asp:DropDownList ID="ddlFilterType" runat="server">
                <asp:ListItem Text="All" Value="" />
                <asp:ListItem Text="Length" Value="Length" />
                <asp:ListItem Text="Weight" Value="Weight" />
                <asp:ListItem Text="Temperature" Value="Temperature" />
            </asp:DropDownList>

            <asp:Label ID="lblFromDate" runat="server" Text="From: " />
            <asp:TextBox ID="txtFromDate" runat="server" TextMode="Date" />

            <asp:Label ID="lblToDate" runat="server" Text="To: " />
            <asp:TextBox ID="txtToDate" runat="server" TextMode="Date" />

            <asp:Button ID="btnFilter" runat="server" Text="Apply Filter" OnClick="btnFilter_Click" />
            <asp:Button ID="btnClearHistory" runat="server" Text="Clear History" OnClick="btnClearHistory_Click" OnClientClick="return confirm('Are you sure you want to clear all history?');" />
        </div>

        <br />

        <asp:GridView ID="GridViewHistory" runat="server" AutoGenerateColumns="true" />
    </form>
</body>
</html>
