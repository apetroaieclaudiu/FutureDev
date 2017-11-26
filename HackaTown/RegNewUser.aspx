<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegNewUser.aspx.cs" Inherits="HackaTown.RegNewUser" %>

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
				<asp:TextBox TextMode="Password" ID="Pass" runat="server"></asp:TextBox>
			</p>
        
    	<p>
			<asp:Button ID="SaveBTN" runat="server" Text="Save" OnClick="SaveBTN_Click" style="
	 background-color:#075CE3;
	 margin: 0px;
	border: none;
	font-size:large;
	border:1px;"/>
			</div>
		</p>
    </form>
</body>
</html>
