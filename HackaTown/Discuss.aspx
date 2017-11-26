<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Discuss.aspx.cs" Inherits="HackaTown.Discuss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#95BCF9">
    <form id="form1" runat="server">

        <div font-family>
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
		<div  style="background-color:#fff; font-family: 'Times New Roman', Times, serif; font-size:large;">
        	<asp:UpdatePanel ID="TopicsPanel" runat="server">
			<ContentTemplate>
				<asp:PlaceHolder ID="PlaceHolder1" runat="server">
				 </asp:PlaceHolder>
			</ContentTemplate>
			</asp:UpdatePanel>
		</div>
		<asp:TextBox ID="WriteMessageTextBox" runat="server" Visible="False"></asp:TextBox>

    	<asp:Button ID="AddMessageButton" runat="server" OnClick="Button1_Click" Text="Write Message" Visible="False" style="
	 background-color:#075CE3;
	 margin: 0px;
	border: none;
	font-size:large;
	border:1px;"/>
    </form>
</body>
</html>
