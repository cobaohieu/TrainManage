<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="TrainManageWeb.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 99%;
            height: 469px;
        }
        .auto-style8 {
            width: 200px;
        }
        .auto-style9 {
            width: 549px;
        }
        .auto-style2 {
            width: 122px;
        }
        .auto-style7 {
            width: 273px;
        }
        .auto-style5 {
            width: 122px;
            height: 26px;
        }
    .auto-style6 {
            height: 26px;
            width: 200px;
        }
        .auto-style10 {
            width: 549px;
            text-align: center;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style10">
                <h2><strong>Trang đăng ký</strong></h2>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Tên đăng nhập:"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtTenTaiKhoan" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="Mật khẩu:"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtMatKhau" runat="server" Width="250px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label4" runat="server" Text="Họ tên"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtHoTen" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label5" runat="server" Text="Năm sinh:"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:Calendar ID="clNamSinh" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" SelectedDate="07/23/2017 12:50:32" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label6" runat="server" Text="Giới tính:"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:DropDownList ID="ddlGioiTinh" runat="server" Width="150px">
                    <asp:ListItem>Nam</asp:ListItem>
                    <asp:ListItem>Nữ</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label7" runat="server" Text="Địa chỉ:"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="txtDiaChi" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label8" runat="server" Text="Email:"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtEmail" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label9" runat="server" Text="Điện thoại:"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="txtDienThoai" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style7">
                <asp:Button ID="btnRegistry" runat="server" Text="Đăng ký" Height="30px" Width="100px" OnClick="btnRegistry_Click" />
            </td>
        </tr>
    </table>

            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
