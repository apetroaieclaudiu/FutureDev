<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Discuss.aspx.cs" Inherits="HackaTown.Discuss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
		<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
			TopicID:
			<asp:Label ID="tID" runat="server" Text="Label"></asp:Label>
			<br />
			Topic name:
			<asp:Label ID="TName" runat="server" Text="Label"></asp:Label>
			<br />
			Date:
			<asp:Label ID="TData" runat="server" Text="Label"></asp:Label>
		</div>

        	<asp:UpdatePanel ID="TopicsPanel" runat="server">
			<ContentTemplate>
				<asp:PlaceHolder ID="PlaceHolder1" runat="server">
				 </asp:PlaceHolder>
			</ContentTemplate>
			</asp:UpdatePanel>

    	<asp:Button ID="AddMessageButton" runat="server" OnClick="Button1_Click" Text="Write Message" />
		<asp:TextBox ID="WriteMessageTextBox" runat="server"></asp:TextBox>
    </form>
</body>
</html>
