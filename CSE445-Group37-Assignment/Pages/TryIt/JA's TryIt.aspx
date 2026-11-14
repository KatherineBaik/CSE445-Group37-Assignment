<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JATryIt.aspx.cs" Inherits="CSE445_Group37_Assignment.Pages.TryIt.JATryIt" %>
<%@ Register Src="~/Controls/WelcomeUser.ascx" TagPrefix="uc" TagName="WelcomeUser" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>JA Components</title>
    <link rel="stylesheet" href="../CSS/JATryIt.css" />
</head>
<body>
    <form id="formJATryIt" runat="server">
        <div>
            <h2>Josh Azura - Component Directory</h2>
            <hr />

            <table border="1" cellpadding="6" style="border-collapse: collapse;">
                <tr>
                    <th>Provider</th><th>Type</th><th>Operation</th>
                    <th>Parameters</th><th>Return</th><th>Description</th><th>Test</th>
                </tr>
                <tr>
                    <td>Josh Azura</td><td>WCF service (SVC)</td><td>RegisterUser</td>
                    <td>string username, string encryptedPassword</td><td>bool</td>
                    <td>Creates a new account. Returns false if the username is empty or already taken.</td>
                    <td>Section 1 below</td>
                </tr>
                <tr>
                    <td>Josh Azura</td><td>Cookie</td><td>RecipeBoxUser</td>
                    <td>key: Username (string)</td><td>-</td>
                    <td>Remembers the registered username for 7 days. Never stores the password.</td>
                    <td>Section 2 below</td>
                </tr>
                <tr>
                    <td>Josh Azura</td><td>User control (ASCX)</td><td>WelcomeUser</td>
                    <td>none (reads the cookie)</td><td>-</td>
                    <td>Shows "Welcome back, name" when the cookie exists, otherwise "Welcome!".</td>
                    <td>Section 3 below</td>
                </tr>
                <tr>
                    <td>Josh Azura</td><td>ASPX page</td><td>RegisterPage</td>
                    <td>username, password, retype</td><td>-</td>
                    <td>Sign-up page. Encrypts locally with the team DLL, calls RegisterUser, sets the cookie.</td>
                    <td><a href="../RegisterPage.aspx">Open page</a></td>
                </tr>
            </table>

            <h3>1. RegisterUser service</h3>
            <p>Username: <asp:TextBox ID="TextBoxTestUser" runat="server"></asp:TextBox></p>
            <p>Password: <asp:TextBox ID="TextBoxTestPassword" runat="server" TextMode="Password"></asp:TextBox></p>
            <p><asp:Button ID="ButtonTestRegister" runat="server" Text="Try it" OnClick="ButtonTestRegister_Click" /></p>
            <p>Result: <asp:Label ID="LabelRegisterResult" runat="server"></asp:Label></p>
            <hr />

            <h3>2. RecipeBoxUser cookie</h3>
            <p>Name to save: <asp:TextBox ID="TextBoxCookieName" runat="server"></asp:TextBox></p>
            <p>
                <asp:Button ID="ButtonSaveCookie" runat="server" Text="Save cookie" OnClick="ButtonSaveCookie_Click" />
                <asp:Button ID="ButtonReadCookie" runat="server" Text="Read cookie" OnClick="ButtonReadCookie_Click" />
                <asp:Button ID="ButtonClearCookie" runat="server" Text="Clear cookie" OnClick="ButtonClearCookie_Click" />
            </p>
            <p>Cookie value: <asp:Label ID="LabelCookieResult" runat="server"></asp:Label></p>
            <hr />

            <h3>3. WelcomeUser user control</h3>
            <p>Save a cookie in section 2 and this greeting updates:</p>
            <uc:WelcomeUser ID="WelcomeUser1" runat="server" />
        </div>
    </form>
</body>
</html>