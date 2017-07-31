<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucRegister.ascx.cs" Inherits="TrainManageWeb.GUI.register" %>
<style type="text/css">

        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style2 {
            width: 161px;
        }
        .auto-style5 {
        width: 161px;
        height: 26px;
    }
    .auto-style6 {
        height: 26px;
    }
</style>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Tên đăng nhập:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTenDangNhap" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="Mật khẩu:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMatKhau" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label3" runat="server" Text="Nhập lại mật khẩu:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMatKhau2" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label4" runat="server" Text="Họ tên"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtHoTen" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label5" runat="server" Text="Năm sinh:"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="txtNamSinh" runat="server" Width="250px"></asp:TextBox>
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" SelectedDate="07/23/2017 12:50:32" Width="200px">
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
            <td>
                <asp:DropDownList ID="ddlGioitinh" runat="server" Width="150px">
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
            <td>
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
            <td class="auto-style2">
                <asp:Label ID="Label10" runat="server" Text="Hình:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtHinh" runat="server" Width="250px"></asp:TextBox>
            &nbsp;<asp:Button ID="btnBrowse" runat="server" Text="Browse" Height="30px" Width="100px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnRegistry" runat="server" Text="Đăng ký" Height="30px" Width="100px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

