<%@ Page Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Web.Modify" Title="修改页" %>

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
		<asp:label id="lbladminID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		登录名
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txtLoginID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		密码
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txtLoginPWD" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		真实姓名
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txtAdminName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		性别
	：</td>
	<td height="45" width="*" align="left">
		
        <asp:RadioButton ID="sexm" runat="server" GroupName="sex" />男
         <asp:RadioButton ID="sexf" runat="server" GroupName="sex" />女
	</td></tr>
    
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

