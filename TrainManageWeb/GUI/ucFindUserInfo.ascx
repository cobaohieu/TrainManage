<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucFindUserInfo.ascx.cs" Inherits="TrainManageWeb.GUI.finduserinfo" %>
<asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
<asp:Button ID="btnSearch" runat="server" Text="Button" />
<p>
    <asp:DataList ID="dlSearch" runat="server">
    </asp:DataList>
</p>

