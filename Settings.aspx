<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="UnitConverterApp.Settings" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Settings</title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Settings</h2>

            <div>
                <h3>Theme Settings</h3>
                <asp:DropDownList ID="ddlThemes" runat="server">
                    <asp:ListItem Text="Light" Value="Light" />
                    <asp:ListItem Text="Dark" Value="Dark" />
                </asp:DropDownList>
                <asp:Button ID="btnSaveTheme" runat="server" Text="Save Theme" OnClick="btnSaveTheme_Click" />
            </div>

            <div>
                <h3>Notification Settings</h3>
                <asp:CheckBox ID="chkEmailNotifications" runat="server" Text="Email Notifications" />
                <asp:CheckBox ID="chkSMSNotifications" runat="server" Text="SMS Notifications" />
                <asp:Button ID="btnSaveNotifications" runat="server" Text="Save Notifications" OnClick="btnSaveNotifications_Click" />
            </div>

            <div>
                <h3>Account Settings</h3>
                <asp:TextBox ID="txtUsername" runat="server" Text="User123" />
                <asp:Button ID="btnSaveAccount" runat="server" Text="Save Account Settings" OnClick="btnSaveAccount_Click" />
            </div>

            <div>
                <h3>Privacy Settings</h3>
                <asp:CheckBox ID="chkAllowDataCollection" runat="server" Text="Allow Data Collection" />
                <asp:Button ID="btnSavePrivacy" runat="server" Text="Save Privacy Settings" OnClick="btnSavePrivacy_Click" />
            </div>
        </div>
    </form>
</body>
</html>

</html>
