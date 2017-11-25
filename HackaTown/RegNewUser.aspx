<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegNewUser.aspx.cs" Inherits="HackaTown.RegNewUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Label ID="IdTest" runat="server" Text="Label"></asp:Label>
			<br />
			<asp:TextBox ID="FName" runat="server"></asp:TextBox>
			<p><asp:TextBox ID="LName" runat="server" OnTextChanged="LName_TextChanged"></asp:TextBox></p>
        </div>
    	
			<asp:TextBox ID="Email" runat="server"></asp:TextBox>
		
		<p>
			<asp:TextBox ID="Pass" runat="server"></asp:TextBox>
		</p>
    	<p>
			<asp:Button ID="SaveBTN" runat="server" Text="SaveBTN" OnClick="SaveBTN_Click" />
		</p>
    </form>
</body>
</html>
