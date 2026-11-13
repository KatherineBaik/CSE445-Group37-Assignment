<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KB's TryIt.aspx.cs" Inherits="CSE445_Group37_Assignment.Pages.TryIt.KB_s_TryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="KBTryItForm" runat="server">
        <div>
            <h2>Encryption/Decryption</h2>
            <p> Key = <asp:TextBox ID="TextBoxKey" runat="server"></asp:TextBox> </p>
            <p> <asp:TextBox ID="TextBoxEncrypt" runat="server"></asp:TextBox> 
                <asp:Button ID="ButtonEncrypt" runat="server" Text="Encrypt It!" OnClick="ButtonEncrypt_Click"/>
                <asp:Label ID="LabelEncryptResult" runat="server" Text="result"></asp:Label>
            </p>
            <p> <asp:TextBox ID="TextBoxDecrypt" runat="server"></asp:TextBox> 
                <asp:Button ID="ButtonDecrypt" runat="server" Text="Decrypt It!" OnClick="ButtonDecrypt_Click"/>
                <asp:Label ID="LabelDecryptResult" runat="server" Text="result"></asp:Label>
            </p>

            <h2>Login as user</h2>
            <p>
                NOTE: If valid credentials are used, no message will appear. 
                Only invalid credentials cause the message to appear.
            </p>
            <p><b>Username : Password </b></p>
            <p>
                user1 : password <br />
                user2 : ilikechickennuggets <br />
                user3 : abc123 <br />
            </p>
            <p>Username: <asp:TextBox ID="TextBoxUsername1" runat="server"></asp:TextBox></p>
            <p>Password: <asp:TextBox ID="TextBoxPassword1" runat="server"></asp:TextBox></p>
            <p><asp:Button ID="ButtonUserLogin" runat="server" Text="User Login" OnClick="ButtonUserLogin_Click" /></p>
            <p><asp:Label ID="LabelInvalidLogin1" runat="server" Text="Username or password is incorrect." Visible="False"></asp:Label></p>

            <h2>Login as staff</h2>
            <p>
                NOTE: If valid credentials are used, no message will appear. 
                Only invalid credentials cause the message to appear.
            </p>
            <p><b>Username : Password </b></p>
            <p>TA : Cse445!</p>
            <p>Username: <asp:TextBox ID="TextBoxUsername2" runat="server"></asp:TextBox></p>
            <p>Password: <asp:TextBox ID="TextBoxPassword2" runat="server"></asp:TextBox></p>
            <p><asp:Button ID="ButtonStaffLogin" runat="server" Text="Staff Login" OnClick="ButtonStaffLogin_Click" /></p>
            <p><asp:Label ID="LabelInvalidLogin2" runat="server" Text="Username or password is incorrect." Visible="False"></asp:Label></p>
        </div>
    </form>
</body>
</html>
