<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="HackaTown.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#95BCF9">
    <form id="form1" runat="server">
        <div style="margin: 0;
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
	font-size:x-large;
	font-family:'Times New Roman', Times, serif;">
        	<asp:Label ID="Label1" runat="server" Text="E-mail"></asp:Label>
			<br />
			<asp:TextBox ID="Email" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
			<br />
			Password<br />
			<asp:TextBox ID="Pass" TextMode="Password" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
			<br />
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign in" style="
	 background-color:#075CE3;
	 margin: 0px;
	border: none;
	font-size:large;
	border:1px;"/>
        </div>
    </form>
</body>
</html>
