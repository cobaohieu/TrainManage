<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucFindResultSubject.ascx.cs" Inherits="TrainManageWeb.GUI.ucFindResultSubject" %>
<asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
<asp:Button ID="btnSearch" runat="server" OnClick="Button1_Click" Text="Tìm" />
<p>
    &nbsp;</p>
<asp:DataList ID="dlSearch" runat="server">
</asp:DataList>

