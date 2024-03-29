USE master
GO
IF DB_ID('QLThuVien') IS NOT NULL
	DROP DATABASE QLThuVien

CREATE DATABASE QLThuVien
GO 
USE QLThuVien
GO

CREATE TABLE ThongTinSach
(
    IDTheLoai    nvarchar(50) NOT NULL,
	IDSach nvarchar(50)        NOT NULL,
	TenSach nvarchar(50)        NOT NULL,
	NhaXuatBan	nvarchar(50)       NULL,
	NgayNhapKho	date NULL,
	Gia	nvarchar(50) NOT NULL,
	TonKho int NULL,
	Primary Key (IDSach),
 )
GO

drop table TaiKhoan
CREATE TABLE TaiKhoan
(
	TaiKhoan nvarchar(50) NOT NULL,
	MatKhau nvarchar(500) NOT NULL,
	PhanQuyen nvarchar(50) NOT NULL
	Primary Key (TaiKhoan),
)

CREATE TABLE NhaXuatBan
(
    IDNhaXuatBan nvarchar(50) NOT NULL,
	TenNhaXuatBan nvarchar(50) NOT NULL,
	DiaChi nvarchar(50) NULL,
	SDT nvarchar(50) NULL,
	primary key(IDNhaXuatBan),	
)
GO

CREATE TABLE TheLoai
(
    IDTheLoai nvarchar(50) NOT NULL,
	TenTheLoai nvarchar(50) NOT NULL,
	primary key(IDTheLoai)
)
GO

CREATE TABLE DocGia
(   
        IDDocGia  nvarchar(50) NOT NULL,
		HoTen nvarchar(50) NOT NULL,
		GioiTinh     bit NULL,
		NgaySinh  date  NULL,
		DiaChi     nvarchar(50) NULL,
		SDT      nvarchar(50) NULL,
		HinhAnh image NULL

		primary key(IDDocGia),
)
GO

CREATE TABLE PhieuMuon
(   
        IDDocGia  nvarchar(50) NOT NULL,
		IDSach nvarchar(50) NOT NULL,
		NgayMuon date NULL,
		NgayTra date NULL,
		SoLuong int NULL,
		primary key(IDDocGia,IDSach),		
)
GO

CREATE TABLE MuonQuaHan
(
	IDDocGia               nvarchar(50) NOT NULL,
	IDSach nvarchar(50) NOT NULL,
	NgayTra             nvarchar(50)NOT NULL,
    SoNgayQuaHan            int NOT NULL,
	TienPhaiTra         nvarchar(50) NOT NULL,
    primary key(IDDocGia,IDSach),	
)
Go