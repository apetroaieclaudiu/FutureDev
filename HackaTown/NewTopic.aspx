<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewTopic.aspx.cs" Inherits="HackaTown.NewTopic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	Titlu:
			<asp:TextBox ID="Titl" runat="server" OnTextChanged="Titl_TextChanged"></asp:TextBox>
			<br />
        </div>
    	<asp:Button ID="SaveButton" runat="server" OnClick="Button1_Click" Text="Post" />
    </form>
</body>
</html>
