<%@ Page Title="Admin" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Web.List" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

            <!--Search -->
    <br />
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                         <a href="Add.aspx">增加</a>
                    </td>
                    <td class="tdbg">
                       
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="adminID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="LoginID" HeaderText="用户名" SortExpression="LoginID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LoginPWD" HeaderText="密码" SortExpression="LoginPWD" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AdminName" HeaderText="真实姓名" SortExpression="AdminName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sex" HeaderText="性别" SortExpression="sex" ItemStyle-HorizontalAlign="Center"  /> 
        <asp:TemplateField HeaderText="性别">
              <ItemTemplate>
                 <%#Eval("Sex").ToString()=="True"?"男":(Eval("Sex").ToString()=="False"?"女":"不详")%>
              </ItemTemplate>
        </asp:TemplateField> 
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="adminID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="adminID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
        <br />
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
