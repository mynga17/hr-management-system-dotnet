CREATE DATABASE QuanLyNhanSu
USE QuanLyNhanSu

CREATE TABLE TblBoPhan
( 
	MaBoPhan char(10) NOT NULL,
	TenBoPhan nchar(10),
	NgayThanhLap datetime,
	CONSTRAINT PK_TblBoPhan PRIMARY KEY (MaBoPhan)	
)

CREATE TABLE TblPhongBan
(
	MaBoPhan char(10),
	MaPhong char(10) NOT NULL,
	TenPhong nvarchar(50),
	NgayThanhLap datetime,
	CONSTRAINT PK_TblPhongBan PRIMARY KEY (MaPhong),
	CONSTRAINT FK_TblPhongBan_TblBoPhan FOREIGN KEY(MaBoPhan) REFERENCES TblBoPhan (MaBoPhan)
)

CREATE TABLE TblHoSoThuViec
(
	MaPhong char(10),
	MaNVTV char(10) NOT NULL,
	HoTen nvarchar(50),
	NgaySinh datetime,
	GioiTinh nvarchar(50),
	DiaChi nvarchar(50),
	TDHocVan nvarchar(50),
	ViTriThuViec nvarchar(50),
	NgayTV datetime,
	ThangTV int,
	CONSTRAINT PK_TblHoSoThuViec PRIMARY KEY (MaNVTV),
	CONSTRAINT FK_TblHoSoThuViec_TblPhongBan FOREIGN KEY(MaPhong) REFERENCES TblPhongBan (MaPhong)
)

CREATE TABLE TblTTNVCoBan
(
	MaBoPhan char(10),
	MaPhong char(10),
	MaNV char(10) NOT NULL,
	HoTen nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(3),
	TTHonNhan nvarchar(50),
	CMTND nvarchar(50),
	NoiCap nvarchar(50),
	ChucVu nvarchar(50),
	LoaiHD nvarchar(50),
	ThoiGian nvarchar(10),
	NgayKy date,
	NgayHetHan date,
	GhiChu nvarchar(100),
	CONSTRAINT PK_TblTTNVCoBan PRIMARY KEY (MaNV),
	CONSTRAINT FK_TblTTNVCoBan_TblPhongBan FOREIGN KEY(MaPhong) REFERENCES TblPhongBan (MaPhong),
	CONSTRAINT FK_TblTTNVCoBan_TblBoPhan FOREIGN KEY(MaBoPhan) REFERENCES TblBoPhan (MaBoPhan)
)

CREATE TABLE TblSoBH
(
	MaNV char(10),
	MaSoBH char(10),
	NgayCapSo datetime,
	NoiCapSo nvarchar(50),
	CONSTRAINT PK_TblSoBH PRIMARY KEY (MaSoBH),
	CONSTRAINT FK_TblSoBH_TblTTNVCoBan FOREIGN KEY(MaNV) REFERENCES TblTTNVCoBan (MaNV)
)

CREATE TABLE TblThaiSan
(
	MaBoPhan char(10),
	MaPhong char(10),
	MaNV char(10),
	HoTen nvarchar(50),
	NgaySinh datetime,
	NgayVeSom datetime,
	NgayNghiSinh datetime,
	NgayLamTroLai datetime,
	TroCapCTY int,
	CONSTRAINT FK_TblThaiSan_TblBoPhan FOREIGN KEY(MaBoPhan) REFERENCES TblBoPhan (MaBoPhan),
	CONSTRAINT FK_TblThaiSan_TblPhongBan FOREIGN KEY(MaPhong) REFERENCES TblPhongBan (MaPhong),
	CONSTRAINT FK_TblThaiSan_TblTTNVCoBan FOREIGN KEY(MaNV) REFERENCES TblTTNVCoBan (MaNV),
)

CREATE TABLE TblTTCaNhan
(
	MaNV char(10),
	HoTen nvarchar(50),
	NoiSinh nvarchar(50),
	NguyenQuan nvarchar(50),
	DCThuongTru nvarchar(100),
	DCTamTru nvarchar(100),
	SDT char(12),
	DanToc nvarchar(30),
	TonGiao nvarchar(20),
	QuocTich nvarchar(20),
	HocVan nvarchar(30),
	GhiChu nvarchar(50),
	CONSTRAINT FK_TblTTCaNhan_TblTTNVCoBan FOREIGN KEY(MaNV) REFERENCES TblTTNVCoBan (MaNV),
)

CREATE TABLE tbuser
(
	Username nvarchar(50) NOT NULL,
	Pass nvarchar(50),
	Quyen nchar(10),
	Ten nvarchar(50),
	NgaySinh date,
	CONSTRAINT PK_tbuser PRIMARY KEY (Username)
)

-----------------------------------------------------------------------------------
INSERT INTO TblBoPhan
VALUES	('MB01', N'Kế toán', '2002-06-12');
INSERT INTO TblBoPhan
VALUES	('MB02', N'Kỹ thuật', '2001-05-25');
INSERT INTO TblBoPhan
VALUES	('MB03', N'Kế hoạch', '2002-09-06');


INSERT INTO TblPhongBan
VALUES	('MB01', 'KT01', N'Kế toán 1', '2003-05-25');
INSERT INTO TblPhongBan
VALUES 	('MB01', 'KT02', N'Kế toán 2', '2003-01-20');
INSERT INTO TblPhongBan
VALUES 	('MB02', 'KTh01', N'Kỹ thuật 1', '2004-08-10');
INSERT INTO TblPhongBan
VALUES 	('MB02', 'KTh02', N'Kỹ thuật 2', '2004-03-15');
INSERT INTO TblPhongBan
VALUES 	('MB03', 'KH01', N'Kế hoạch 1', '2005-01-22');
INSERT INTO TblPhongBan
VALUES 	('MB03', 'KH02', N'Kế hoạch 2', '2005-02-17');


INSERT INTO TblHoSoThuViec
VALUES	('KT01', '0001', N'Lê Văn Hoàng','2000-05-14', N'Nam', N'Bắc Ninh', N'Đại học', N'Nhân viên', '2019-09-23', 3);
INSERT INTO TblHoSoThuViec
VALUES	('KTh01', '0002', N'Trần Tuấn Đạt', '2000-01-17', N'Nam', N'Hà Nội', N'Đại học', N'Nhân viên', '2019-05-10', 3);
INSERT INTO TblHoSoThuViec
VALUES	('KH01', '0003', N'Nguyễn Hoa Quỳnh','2000-09-28', N'Nữ', N'Bắc Giang', N'Đại học', N'Tổ trưởng', '2019-03-20', 3);
INSERT INTO TblHoSoThuViec
VALUES	('KT02', '0004', N'Phan Vũ Linh','2001-07-03', N'Nam', N'Hà Nội', N'Cao đẳng', N'Nhân viên', '2019-10-18', 3);
INSERT INTO TblHoSoThuViec
VALUES	('KH02', '0005', N'Phạm Uyển An','2002-03-10', N'Nữ', N'Phú Thọ', N'Cao đẳng', N'Nhân viên', '2019-08-17', 3);


INSERT INTO TblTTNVCoBan
VALUES ('MB01', 'KT01', '001', N'Lê Văn Bình', '1989-05-22', N'Nam', N'Đã kết hôn', '12323589', N'Bắc Ninh', N'Nhân viên', N'Kinh tế', N' 24 tháng', '2018-10-18', '2020-10-18', N'Nhân viên');
INSERT INTO TblTTNVCoBan
VALUES ('MB01', 'KT02', '002', N'Nguyễn Ánh Mai', '1990-06-12', N'Nữ', N'Đã kết hôn', '12323947', N'Hà Nội', N'Trưởng phòng', N'Kinh tế', N' 36 tháng', '2018-11-21', '2021-11-21', N'Trưởng phòng');
INSERT INTO TblTTNVCoBan
VALUES ('MB01', 'KT01', '003', N'Trần Minh Sang', '1990-10-12', N'Nam', N'Độc thân', '12323290', N'Bắc Giang', N'Nhân viên', N'Kinh tế', N' 24 tháng', '2018-03-07', '2020-03-07', N'Nhân viên');
INSERT INTO TblTTNVCoBan
VALUES ('MB02', 'KTh01', '004', N'Dương Ngọc Văn', '1988-03-04', N'Nam', N'Đã kết hôn', '12323957', N'Hồ Chí Minh', N'Phó phòng', N'Kinh tế', N' 36 tháng', '2018-09-05', '2021-09-05', N'Phó phòng');
INSERT INTO TblTTNVCoBan
VALUES ('MB02', 'KTh02', '005', N'Phan Yến Như', '1991-12-29', N'Nữ', N'Độc thân', '12323762', N'Nghệ An', N'Nhân viên', N'Kinh tế', N' 24 tháng', '2018-10-25', '2020-10-25', N'Nhân viên');
INSERT INTO TblTTNVCoBan
VALUES ('MB02', 'KTh02', '006', N'Lại Ngọc Hân', '1994-01-17', N'Nữ', N'Đã kết hôn', '12323857', N'Đồng Nai', N'Nhân viên', N'Kinh tế', N' 36 tháng', '2018-07-28', '2021-07-28', N'Nhân viên');
INSERT INTO TblTTNVCoBan
VALUES ('MB03', 'KH01', '007', N'Võ Trường Huy', '1992-04-21', N'Nam', N'Đã kết hôn', '12323025', N'Đà Nẵng', N'Nhân viên', N'Kinh tế', N' 24 tháng', '2018-09-19', '2020-09-19', N'Nhân viên');
INSERT INTO TblTTNVCoBan
VALUES ('MB03', 'KH02', '008', N'Phạm Mỹ An', '1992-03-07', N'Nữ', N'Độc thân', '12323481', N'Cà Mau', N'Cán bộ', N'Kinh tế', N' 36 tháng', '2018-12-30', '2021-12-30', N'Cán bộ');
INSERT INTO TblTTNVCoBan
VALUES ('MB03', 'KH01', '009', N'Hồ Huy Cường', '1989-09-01', N'Nam', N'Đã kết hôn', '12323550', N'Hải Dương', N'Nhân viên', N'Kinh tế', N' 24 tháng', '2018-05-11', '2020-05-11', N'Nhân viên');
INSERT INTO TblTTNVCoBan
VALUES ('MB03', 'KH02', '0010', N'Ngô Thanh Phúc', '1992-01-12', N'Nam', N'Đã kết hôn', '12323878', N'Quảng Nam', N'Nhân viên', N'Kinh tế', N' 24 tháng', '2018-04-20', '2020-04-20', N'Nhân viên');


INSERT INTO TblSoBH
VALUES ('001', 'BH1', '2019-05-27', N'Bắc Ninh');
INSERT INTO TblSoBH
VALUES	('002', 'BH2', '2019-05-27', N'Hà Nội');
INSERT INTO TblSoBH
VALUES	('003', 'BH3', '2019-05-27', N'Bắc Giang');
INSERT INTO TblSoBH
VALUES	('004', 'BH4', '2019-05-27', N'Hồ Chí Minh');
INSERT INTO TblSoBH
VALUES	('005', 'BH5', '2019-05-27', N'Nghệ An');
INSERT INTO TblSoBH
VALUES	('006', 'BH6', '2019-05-27', N'Đồng Nai');


INSERT INTO TblThaiSan
VALUES ('MB01', 'KT02', '002', N'Nguyễn Ánh Mai', '1990-06-12', '2019-06-15', '2019-06-15', '2020-02-01', 15000000);
INSERT INTO TblThaiSan
VALUES	('MB02', 'KTh02', '006', N'Lại Ngọc Hân', '1994-01-17', '2019-08-19', '2019-08-19', '2020-04-01', 15000000);


INSERT INTO TblTTCaNhan
VALUES ('001', N'Lê Văn Bình', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn - Bắc Ninh', N'Từ Sơn - Bắc Ninh', '03981258656', 'Kinh', N'Phật giáo', N'Việt Nam', N'Cao đẳng', N'Nhân viên');
INSERT INTO TblTTCaNhan
VALUES	('002', N'Nguyễn Ánh Mai', N'Hà Nội', N'Hà Nội', N'Đông Anh - Hà Nội', N'Đông Anh - Hà Nội', '03981258751', 'Kinh', N'Không', N'Việt Nam', N'Đại học', N'Trưởng phòng');
INSERT INTO TblTTCaNhan
VALUES	('003', N'Trần Minh Sang', N'Bắc Giang', N'Bắc Giang', N'Lục Ngạn - Bắc Giang', N'Lục Ngạn - Bắc Giang', '03981258613', 'Kinh', N'Không', N'Việt Nam', N'Cao đắng', N'Nhân viên');
INSERT INTO TblTTCaNhan
VALUES	('004', N'Dương Ngọc Văn', N'Hồ Chí Minh', N'Hồ Chí Minh',  N'Hồ Chí Minh', N'Long Biên - Hà Nội','03981258091', 'Hoa', N'Thiên chúa', N'Việt Nam', N'Đại học', N'Phó phòng');
INSERT INTO TblTTCaNhan
VALUES	('005', N'Phan Yến Như', N'Nghệ An', N'Nghệ An', N'Nghệ An', N'Từ Sơn - Bắc Ninh', '03981258740', 'Kinh', N'Phật giáo', N'Việt Nam', N'Đại học', N'Nhân viên');
INSERT INTO TblTTCaNhan
VALUES	('006', N'Lại Ngọc Hân', N'Đồng Nai', N'Đồng Nai', N'Đông Anh - Hà Nội', N'Đông Anh - Hà Nội', '03981258098', 'Kinh', N'Không', N'Việt Nam', N'Đại học', N'Nhân viên');
INSERT INTO TblTTCaNhan
VALUES	('007', N'Võ Trường Huy', N'Đà Nắng', N'Đà Nắng', N'Đà Nắng', N'Tiên Du - Bắc Ninh', '03981258834', 'Kinh', N'Thiên chúa', N'Việt Nam', N'Đại học', N'Nhân viên');
INSERT INTO TblTTCaNhan
VALUES	('008', N'Phạm Mỹ An', N'Cà Mau', N'Cà Mau', N'Cà Mau', N'Nam Từ Liêm - Hà Nội', '03981258605', 'Kinh', N'Không', N'Việt Nam', N'Đại học',  N'Cán bộ');
INSERT INTO TblTTCaNhan
VALUES	('009', N'Hồ Huy Cường', N'Hải Dương', N'Hải Dương', N'Hải Dương', N'Quế Võ - Bắc Ninh', '03981258723', 'Hoa', N'Phật giáo', N'Việt Nam', N'Cao đẳng', N'Nhân viên');
INSERT INTO TblTTCaNhan
VALUES	('0010', N'Ngô Thanh Phúc', N'Quảng Nam', N'Quảng Nam', N'Quảng Nam', N'Nam Từ Liêm - Hà Nội', '03981258595', 'Kinh', N'Không', N'Việt Nam', N'Đại học', N'Nhân viên');

INSERT INTO tbuser
VALUES	('Tu','123','Admin',N'Cẩm Tú','2003-01-18');
INSERT INTO tbuser
VALUES	('Nga','abc','Admin',N'Mỹ Nga','2003-09-17');
INSERT INTO tbuser
VALUES	('Binh','456','user',N'Văn Bình','2004-03-29');