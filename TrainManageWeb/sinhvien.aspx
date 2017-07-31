<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="sinhvien.aspx.cs" Inherits="TrainManageWeb.sinhvien1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>

</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="main">
    <span class="auto-style2">ĐÂY LÀ TRANG CỦA SINH VIÊN
    </span>
    <table class="auto-style1">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Thông Tin Cá Nhân"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="dvSinhVien" runat="server">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

