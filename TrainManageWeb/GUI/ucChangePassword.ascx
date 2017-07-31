<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucChangePassword.ascx.cs" Inherits="TrainManageWeb.changepassword" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>

<table class="auto-style1">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Người dùng:"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblTenDangNhap" runat="server" Text="&nbsp;"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Mật khẩu cũ:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server" Width="250px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Mật khẩu mới:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPasswordNew" runat="server" Width="250px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Nhập lại mật khẩu:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPasswordRe" runat="server" Width="250px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Đổi mật khẩu" Height="30px" Width="100px" />
        </td>
    </tr>
</table>

