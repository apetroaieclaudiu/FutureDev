<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="HackaTown.MainPage" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
</head>
<body bgcolor="#95BCF9" style="padding:0; margin: 0;">
    <form id="form1" runat="server">
		<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
		<div style="background-color:#4286f4; padding: 0; margin: 0; widht:100%;">
        <div style="color: black; font-size: large; font-weight: bold; font-family: 'Times New Roman', Times, serif">You are:<asp:Button ID="Sign" runat="server" OnClick="Button1_Click" Text="Sign Out" style="
	 background-color:#075CE3;
	 margin: 0px;
	border: none;
	float:right;
	font-size:large;
	padding:1%;border:1px;"/>
			<asp:Button ID="SupButton" runat="server" OnClick="Button1_Click1" Text="Sign Up" style="
	 background-color:#075CE3;
	 margin: 0px;
	border: none;
	float:right;
	font-size:large;
	padding:1%;
	border:1px;"/>
			</div>
		<asp:Label ID="uName" runat="server" Text="Label" style="font-size: large; font-family:'Times New Roman', Times, serif; padding:2%;"></asp:Label>
&nbsp;<div>
        	<div style="line-height: 12px;
     position:absolute;
     top:1%;
     right:5%;
	 display:inline-block;">
				</div>
			<asp:Button ID="UMGMT" runat="server" OnClick="UMGMT_Click" Text="User Management" Visible="False" style="
	 background-color:#075CE3;
	 margin: 0px;
	border: none;
	font-size:large;
	border:1px;"/>
		</div>
        </div>
    	<p>
			&nbsp;</p>
		<p>
			<asp:Button ID="AddTop" runat="server" Text="Add Topic" OnClick="Button2_Click" style="
	 background-color:#075CE3;
	 margin: 0px;
	border: none;
	font-size:large;
	border:1px;"/>
		</p>
		<div  style="background-color:#fff; font-family: 'Times New Roman', Times, serif; font-size:large;">
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
