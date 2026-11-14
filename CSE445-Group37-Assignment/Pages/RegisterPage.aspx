<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="CSE445_Group37_Assignment.Pages.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Page</title>
    <link rel ="stylesheet" href="CSS/RegisterPage.css"/>
</head>
<body>
    <form id="formRegisterPage" runat="server">
        <div>
            <h2>Please register</h2>
            <hr/>
                <p>Username: <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredUsername" runat="server" ControlToValidate="TextBoxUsername" ErrorMessage="Username is required" ForeColor="Red" />
                </p>
                <p>Password: <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredPassword" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Password is required" ForeColor="Red" />
                </p>
                <p>Retype Password: <asp:TextBox ID="TextBoxConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredConfirmPassword" runat="server" ControlToValidate="TextBoxConfirmPassword" ErrorMessage="Please retype your password" ForeColor="Red" />
                    <asp:CompareValidator ID="ComparePasswords" runat="server" ControlToValidate="TextBoxConfirmPassword" ControlToCompare="TextBoxPassword" ErrorMessage="Passwords don't match" ForeColor="Red" />
                </p>
                
                <p><asp:Button ID="ButtonUserRegister" runat="server" Text="Register" OnClick="ButtonUserRegister_Click" /></p>
                <p><asp:Label ID="LabelUserExists" runat="server" Text="User already exists." Visible="False"></asp:Label></p>
                <p>Already have an account? <a href="LoginPage.aspx">Log in here</a></p>
        </div>
    </form>
</body>
</html>