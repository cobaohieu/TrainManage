Create database trainmanage
On
(NAME = 'trainmanage_data', FILENAME = 'C:\Databases\trainmanagedata.mdf',
 SIZE = 10, MAXSIZE = 50, FILEGROWTH = 5)
Log on
(NAME = 'trainmanage_log', FILENAME = 'C:\Databases\trainmanagelog.mdf',
 SIZE = 5MB, MAXSIZE = 25MB, FILEGROWTH = 5MB)
Go

--drop Database trainmanage

use trainmanage
go
--1
create table tblKhoa(
id int primary key  identity(1,1) not null,
makhoa varchar(50) unique,
tenkhoa nvarchar(100),
sodienthoai varchar(11)
)
go
--2
create table tblChucVu(
id int primary key identity(1,1) not null,
machucvu varchar(50) unique,
tenchucvu nvarchar(100)
)
go
--3
create table tblNienKhoa(
id int primary key identity(1,1) not null,
manienkhoa varchar(50) unique,
tennienkhoa nvarchar(100),
nambatdau date default getdate(),
namketthuc date default getdate()
)
go
--4
create table tblTinChi(
id int primary key identity(1,1) not null,
matinchi varchar(50) unique,
sotinchi varchar(2)
)
go
--5
create table tblHocKy(
id int primary key identity(1,1) not null,
mahocky varchar(50) unique,
tenhocky nvarchar(100)
)
go
--6
create table tblTrangThai(
id int primary key identity(1,1) not null,
matrangthai varchar(50) unique,
tentrangthai nvarchar(100)
)
go
--7
create table tblChuongTrinh(
id int primary key identity(1,1) not null,
idtrangthai int not null foreign key references tblTrangThai(id),
machuongtrinh varchar(50) unique,
tenchuongtrinh nvarchar(100)
)
go
--8
create table tblNhom(
id int primary key identity(1,1) not null,
manhom nvarchar(50) unique,
tennhom nvarchar(100)
)
--9
create table tblLop(
id int primary key identity(1,1) not null,
idkhoa int not null foreign key references tblKhoa(id),
idnienkhoa int not null foreign key references tblNienKhoa(id),
malop nvarchar(50) unique,
tenlop nvarchar(100),
siso varchar(50)
)
go
--10
create table tblMonHoc(
id int primary key identity(1,1) not null,
idchuongtrinh int not null  foreign key references tblChuongTrinh(id),
idhocky int not null  foreign key references tblHocKy(id),
idtinchi int not null  foreign key references tblTinChi(id), 
mamonhoc nvarchar(50) unique,
tenmonhoc nvarchar(100)
)
go
--11
create table tblTaiKhoan(
id int primary key identity(1,1) not null,
idnhom int not null foreign key references tblNhom(id),
tentaikhoan nvarchar(100) not null, 
matkhau nvarchar(100),
hoten nvarchar(100),
namsinh date default getdate(),
gioitinh nvarchar(3),
diachi nvarchar(100),
email nvarchar(100),
dienthoai nvarchar(12)
)
--12
create table tblQuanTri(
id int primary key identity(1,1) not null,
idnhom int not null foreign key references tblNhom(id),
idtaikhoan int not null foreign key references tblTaiKhoan(id)
)
--13
create table tblSinhVien(
id int primary key identity(1,1) not null,
idlop int not null foreign key references tblLop(id),
idtaikhoan int not null foreign key references tblTaiKhoan(id),
idtrangthai int not null foreign key references tblTrangThai(id)
)
go
--14
create table tblGiaoVien(
id int primary key identity(1,1) not null,
idchucvu int not null foreign key references tblChucVu(id),
idlop int not null foreign key references tblLop(id),
idkhoa int not null foreign key references tblKhoa(id),
idmonhoc int not null foreign key references tblMonHoc(id),
idtaikhoan int not null foreign key references tblTaiKhoan(id)
)
go
--15
create table tblKetQua(
id int primary key identity(1,1) not null,
idsinhvien int not null foreign key references tblSinhVien(id),
idmonhoc int not null foreign key references tblMonhoc(id),
diemtrungbinh float,
diemthilan1 float,
diemthilan2 float,
diemtongket float,
hanhkiem nvarchar(100),
ghichu nvarchar(100)
)
go
--16
create table tblDangNhap(
id int primary key identity(1,1) not null,
idtaikhoan int not null foreign key references tblTaiKhoan(id),
diachiip nvarchar(50),
ngaydangnhapcuoi datetime,
Session nvarchar(10)
)
--17
create table tblBanTin(
id int primary key identity(1,1) not null,
tieude nvarchar(100),
noidung text,
ngay datetime,
hinh image
)
--
--