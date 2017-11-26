<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewTopic.aspx.cs" Inherits="HackaTown.NewTopic" %>

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
        	Titlu:
			<asp:TextBox ID="Titl" runat="server" OnTextChanged="Titl_TextChanged"></asp:TextBox>
			<br />
        
    	<asp:Button ID="SaveButton" runat="server" OnClick="Button1_Click" Text="Post" style="
	 background-color:#075CE3;
	 margin: 0px;
	border: none;
	font-size:large;
	border:1px;"/>
			</div>
    </form>
</body>
</html>
