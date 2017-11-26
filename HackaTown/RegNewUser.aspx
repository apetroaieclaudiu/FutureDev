<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegNewUser.aspx.cs" Inherits="HackaTown.RegNewUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<p>
				SIGN UP<br /><br />
        		First Name:<br />
				<asp:TextBox ID="FName" runat="server"></asp:TextBox>
			</p>
			<p>
				Last Name:<br />
				<asp:TextBox ID="LName" runat="server" OnTextChanged="LName_TextChanged"></asp:TextBox>
			</p>
			<p>
				E-mail:<br />
				<asp:TextBox ID="Email" runat="server"></asp:TextBox>
			</p>
    	
			<p>
				Password:<br />
				<asp:TextBox ID="Pass" runat="server"></asp:TextBox>
			</p>
        </div>
    	<p>
			<asp:Button ID="SaveBTN" runat="server" Text="Save" OnClick="SaveBTN_Click" />
		</p>
    </form>
</body>
</html>
