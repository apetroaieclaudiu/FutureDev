<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="HackaTown.MainPage" %>
<%@ Register TagPrefix="uc" TagName="Topic" Src="~/Topic.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
	
    <form id="form1" runat="server">
		<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        You are:
		<asp:Label ID="uName" runat="server" Text="Label"></asp:Label>
&nbsp;<div>
        	<asp:Button ID="Sign" runat="server" OnClick="Button1_Click" Text="Sign Out" />
			<asp:Button ID="SupButton" runat="server" OnClick="Button1_Click1" Text="Sign Up" />
        </div>
    	<p>
			&nbsp;</p>
		<p>
			<asp:Button ID="Button2" runat="server" Text="Add Topic" OnClick="Button2_Click" />
		</p>
		<asp:UpdatePanel ID="TopicsPanel" runat="server">
			<ContentTemplate>
				<asp:PlaceHolder ID="PlaceHolder1" runat="server">
				 </asp:PlaceHolder>
			</ContentTemplate>
		</asp:UpdatePanel>
		
    </form>
</body>
</html>
