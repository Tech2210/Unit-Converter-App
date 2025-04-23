<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UnitConverterApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Unit Converter</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" />
    <style>
        body {
            background-color: #87CEEB;
            font-family: Arial, sans-serif;
        }
        .converter-container {
            max-width: 400px;
            margin: auto;
            padding: 20px;
            background-color: #ffffff;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
        }
        .converter-container h2 {
            text-align: center;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
        }
        .form-group input,
        .form-group select {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }
        .form-actions {
            text-align: center;
        }
        .form-actions button {
            padding: 10px 20px;
            font-size: 16px;
        }
        .result {
            margin-top: 20px;
            text-align: center;
            font-weight: bold;
            color: blue;
        }
        .history-link, .nav-links {
            margin-top: 15px;
            text-align: center;
        }
        .nav-links a {
            margin: 0 5px;
            text-decoration: none;
            color: #333;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="converter-container">
            <h2><i class="fas fa-exchange-alt"></i> Unit Converter</h2>

            <div class="form-group">
                <label for="ddlConversionType">Conversion Type:</label>
                <asp:DropDownList ID="ddlConversionType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlConversionType_SelectedIndexChanged">
                    <asp:ListItem Text="-- Select Conversion Type --" Value="" />
                    <asp:ListItem Text="Length" Value="Length" />
                    <asp:ListItem Text="Weight" Value="Weight" />
                    <asp:ListItem Text="Temperature" Value="Temperature" />
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label for="txtInputValue">Enter Value:</label>
                <asp:TextBox ID="txtInputValue" runat="server" />
            </div>

            <div class="form-group">
                <label for="ddlFromUnit">From Unit:</label>
                <asp:DropDownList ID="ddlFromUnit" runat="server" />
            </div>

            <div class="form-group">
                <label for="ddlToUnit">To Unit:</label>
                <asp:DropDownList ID="ddlToUnit" runat="server" />
            </div>

            <div class="form-actions">
                <asp:Button ID="btnConvert" runat="server" CssClass="btn btn-primary" OnClick="btnConvert_Click" Text="Convert" />
            </div>

            <div class="result">
                <asp:Label ID="lblResult" runat="server" />
            </div>

            <div class="history-link">
                <a href="History.aspx"><i class="fas fa-history"></i> View Conversion History</a>
            </div>

            <div class="nav-links">
                <a href="Settings.aspx">Settings</a> |
                <a href="Stats.aspx">Statistics</a> |
                <a href="Help.aspx">Help</a>
            </div>
        </div>
    </form>
</body>
</html>
