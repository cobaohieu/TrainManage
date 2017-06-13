﻿Create database trainmanage
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
/*create table tblChucVu(
id int primary key identity(1,1) not null,
machucvu varchar(50) unique,
tenchucvu nvarchar(100)
)
go
*/
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
create table tblChuongTrinhDaoTao(
id int primary key identity(1,1) not null,
machuongtrinh varchar(50) unique,
tenchuongtrinh nvarchar(100)
)
go
--8
create table tblTaiKhoan(
id int primary key identity(1,1) not null, 
tentaikhoan nvarchar(100) unique, 
matkhau nvarchar(100), 
nhom nvarchar(100)
)
--8.1
create table tblThongTin(
id int primary key identity(1,1) not null,
idTaiKhoan int not null foreign key references tblTaiKhoan(id) on update cascade on delete cascade,
hoten nvarchar(100),
chucvu nvarchar(100),
namsinh date default getdate(),
gioitinh nvarchar(3),
diachi nvarchar(100),
)
go
--9
create table tblLop(
id int primary key identity(1,1) not null,
idkhoa int not null foreign key references tblKhoa(id) on update cascade on delete cascade,
idnienkhoa int not null foreign key references tblNienKhoa(id) on update cascade on delete cascade,
malop varchar(50) unique,
tenlop nvarchar(100),
siso int
)
go
--10
create table tblMonHoc(
id int primary key identity(1,1) not null,
idchuongtrinh int foreign key references tblChuongTrinhDaoTao(id) on update cascade on delete cascade,
idhocky int foreign key references tblHocKy(id) on update cascade on delete cascade,
idtinchi int foreign key references tblTinChi(id) on update cascade on delete cascade, 
mamonhoc varchar(50) unique,
tenmonhoc nvarchar(100)
)
go
--11
/*
create table tblGiaoVien(
id int primary key identity(1,1) not null,
idchucvu int not null foreign key references tblChucVu(id) on update cascade on delete cascade,
idkhoa int not null foreign key references tblKhoa(id) on update cascade on delete cascade,
idmonhoc int not null foreign key references tblMonHoc(id) on update cascade on delete cascade,
magiaovien varchar(50) unique,
tengiaovien nvarchar(100),
namsinh date default getdate(),
gioitinh nvarchar(3),
noisinh nvarchar(100),
diachi nvarchar(100)
)
go
*/
--12
create table tblSinhVien(
id int primary key identity(1,1) not null,
idlop int not null foreign key references tblLop(id) on update cascade on delete cascade,
idtrangthai int not null foreign key references tblTrangThai(id) on update cascade on delete cascade,
masinhvien varchar(50) unique,
tensinhvien nvarchar(100),
namsinh date default getdate(),
gioitinh nvarchar(3),
noisinh nvarchar(100),
diachi nvarchar(100)
)
go
--13
create table tblKetQua(
id int primary key identity(1,1) not null,
idsinhvien int not null foreign key references tblSinhVien(id) on update cascade on delete cascade,
idmonhoc int not null foreign key references tblMonhoc(id) on update cascade on delete cascade,
diemtrungbinh float,
diemthilan1 float,
diemthilan2 float,
diemtongket float,
hanhkiem nvarchar(100),
ghichu nvarchar(100),
)
go