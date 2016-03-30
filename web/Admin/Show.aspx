<%@ Page Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Web.Show" Title="显示页" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="45" width="30%" align="right">
		编号
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lbladminID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		登录名
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblLoginID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		密码
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblLoginPWD" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		真实姓名
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblAdminName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		性别
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblsex" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




