<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserController.aspx.cs" Inherits="HackaTown.UserController" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#95BCF9">
    <form id="form1" runat="server">
        <div style="color: black; font-size: large; font-weight: bold; font-family: 'Times New Roman', Times, serif">
		<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="TopicsPanel" runat="server">
			<ContentTemplate>
				<asp:PlaceHolder ID="PlaceHolder1" runat="server">
				 </asp:PlaceHolder>
			</ContentTemplate>
			</asp:UpdatePanel>
		</div>
    </form>
</body>
</html>
