<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="HackaTown.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Label ID="Label1" runat="server" Text="E-mail"></asp:Label>
			<br />
			<asp:TextBox ID="Email" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
			<br />
			Password<br />
			<asp:TextBox ID="Pass" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
			<br />
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign in" />
        </div>
    </form>
</body>
</html>
