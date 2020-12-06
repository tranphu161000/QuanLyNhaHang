CREATE DATABASE QuanLyNhaHang
go
USE QuanLyNhaHang

go

CREATE TABLE PhanQuyen(
	maquyen varchar(5)primary key,
	tenquyen nvarchar(20)
)

INSERT INTO PhanQuyen VALUES('1', N'Chủ Quán') 
INSERT INTO PhanQuyen VALUES('2', N'Quản Lý')
INSERT INTO PhanQuyen VALUES('3', N'Nhân Viên')

go

CREATE TABLE NhanVien(
	manv varchar(5) primary key,
	tennv nvarchar(50),
	tendangnhap varchar(20),
	ngaysinh varchar(20),
	diachi nvarchar(50),
	dienthoai varchar(15),
	matkhau varchar(20),
	maquyen varchar(5),
	
	CONSTRAINT FK_NhanVien_PhanQuyen FOREIGN KEY (maquyen) REFERENCES PhanQuyen(maquyen)
)

go
INSERT [dbo].[KhachDatBan] ([maban], [tenban], [khuvuc], [tensp], [soluong]) VALUES (N'02', N'Nguyễn Văn A', N'', N'Lẩu thái', N'2')
INSERT [dbo].[NhanVien] ([manv], [tennv], [tendangnhap], [ngaysinh], [diachi], [dienthoai], [matkhau], [maquyen]) VALUES (N'NV001', N'TrầnThành Phú', N'51800468', N'03/09/2000', N'Long An', N'0783338531', N'1234', N'1')
INSERT [dbo].[NhanVien] ([manv], [tennv], [tendangnhap], [ngaysinh], [diachi], [dienthoai], [matkhau], [maquyen]) VALUES (N'NV002', N'Trần Minh Thông', N'51800825', N'30/12/1998', N'TP. HCM', N'0987654676', N'1234', N'3')
INSERT [dbo].[NhanVien] ([manv], [tennv], [tendangnhap], [ngaysinh], [diachi], [dienthoai], [matkhau], [maquyen]) VALUES (N'NV003', N'Nguyễn Phạm Thiên Thư', N'51800125', N'09/06/2000', N'TP. HCM', N'0907891234', N'1234', N'2')
INSERT [dbo].[PhanQuyen] ([maquyen], [tenquyen]) VALUES (N'1', N'Chủ Quán')
INSERT [dbo].[PhanQuyen] ([maquyen], [tenquyen]) VALUES (N'2', N'Quản Lý')
INSERT [dbo].[PhanQuyen] ([maquyen], [tenquyen]) VALUES (N'3', N'Nhân Viên')
INSERT [dbo].[SanPham] ([masp], [tensp], [dongia]) VALUES (N'001', N'Gà nướng', N'145.000')
INSERT [dbo].[SanPham] ([masp], [tensp], [dongia]) VALUES (N'002', N'Lẩu thái', N'250.000')
INSERT [dbo].[SanPham] ([masp], [tensp], [dongia]) VALUES (N'003', N'Lẩu bò', N'250.000')
INSERT [dbo].[SanPham] ([masp], [tensp], [dongia]) VALUES (N'004', N'Nghếu Hấp Thái', N'60.000')
go

CREATE TABLE SanPham(
	masp varchar(5)primary key,
	tensp nvarchar(50),
	dongia nvarchar(20)
)

go

CREATE TABLE KhachDatBan(
	maban varchar(5) primary key,
	tenban nvarchar(50),
	khuvuc nvarchar(10),
	tensp nvarchar(50),
	soluong varchar(10)
)

go

CREATE TABLE HoaDon(
	mahd varchar(5) primary key,
	maban varchar(5),
	masp varchar(5),
	manv varchar(5),
	ngayxuat varchar(20),
	soluongmua int,
	dongiaban int,
	thanhtien varchar(10),
	
	CONSTRAINT FK_HoaDon_KhachDatBan FOREIGN KEY (maban) REFERENCES KhachDatBan(maban),
	CONSTRAINT FK_HoaDon_SanPham FOREIGN KEY (masp) REFERENCES SanPham(masp),
	CONSTRAINT FK_HoaDon_NhanVien FOREIGN KEY (manv) REFERENCES NhanVien(manv)
)

