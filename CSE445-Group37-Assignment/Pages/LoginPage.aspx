<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="CSE445_Group37_Assignment.Pages.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="CSS/LoginPage.css"/>
</head>
<body>
    <form id="formLoginPage" runat="server">
        <div>
            <p>Username: <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox></p>
            <p>Password: <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox></p>
            <p><asp:Button ID="ButtonUserLogin" runat="server" Text="User Login" OnClick="ButtonUserLogin_Click" /></p>
            <p><asp:Button ID="ButtonStaffLogin" runat="server" Text="Staff Login" OnClick="ButtonStaffLogin_Click" /></p>

            <p><asp:Label ID="LabelInvalidLogin" runat="server" Text="Username or password is incorrect." Visible="False"></asp:Label>
            </p>
        </div>
        
    </form>
</body>
</html>
