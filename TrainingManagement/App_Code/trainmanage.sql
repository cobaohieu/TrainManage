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
--
create table taikhoan(
id int primary key, 
tentk nvarchar(50), 
matkhau nvarchar(50), 
nhom nvarchar(50)
)
--
create table sinhvien(
idsinhvien int primary key,
tensinhvien nvarchar(50),
namsinh smalldatetime,
gioitinh nvarchar(3),
email nvarchar(50),
diachi nvarchar(50)
)
--
create table giaovien(
idgiaovien int primary key,
tengiaovien nvarchar(50),
namsinh smalldatetime,
gioitinh nvarchar(3),
email nvarchar(50),
diachi nvarchar(50)
)
--
create table quantri(
idquantri int primary key,
tenquantri nvarchar(50),

)
--
create table chuongtrinhdaotao(
idchuongtrinh int primary key,
tenchuongtrinh nvarchar(50)
)
--
create table monhoc(
idmonhoc int primary key,
tenmonhoc nvarchar(50)
)
--
create table ketqua(
idketqua int primary key,
tenketqua nvarchar(50)
)
--
create table lop(
idlop int primary key,
tenlop nvarchar(50)
)
--
create table khoa(
idkhoa int primary key,
tenkhoa nvarchar(50)
)
--
create table chucvu(
idchucvu int primary key,
tenchucvu nvarchar(50)
)
--
create table nienkhoa(
idnienkhoa int primary key,
tennienkhoa nvarchar(50)
)
--
create table diem(
iddiem int primary key,
sodiem varchar(5)
)
--
create table tinchi(
idtinchi int primary key,
sotinchi varchar(2)
)
--
create table trangthaisv(
idtrangthaisv int primary key,
tentrangthai nvarchar(100)
)
--
create table chitietmonhoc(
idmonhoc int,
iddiem int,
idketqua int
)
--
create table chitietsinhvien(
idsinhvien int,
idlop int,
idkhoa int,
iddiem int,
idtinchi int,
idketqua int,
idtrangthai int
)
--
create table chitietgiaovien(
idgiaovien int,
idlop int,
idkhoa int,
idchucvu int,
idmonhoc int,
iddiem int,
)
create table chitietadmin(
idsinhvien int,
idquantri int,
id int,
idchuongtrinh int,
idmonhoc int,
idketqua int,
idlop int,
idkhoa int,
idnienkhoa int,
iddiem int,
idtinchi int,
idtrangthai int,
idchucvu int
)
