<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="HackaTown.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        You are:
		<asp:Label ID="uName" runat="server" Text="Label"></asp:Label>
&nbsp;<div>
        	<asp:Button ID="Sign" runat="server" OnClick="Button1_Click" Text="Sign Out" />
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Sign Up" />
        </div>
    </form>
</body>
</html>
