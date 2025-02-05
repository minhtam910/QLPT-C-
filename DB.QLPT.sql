
--KIEM TRA SU TON TAI DATABASE
USE MASTER
GO
IF EXISTS (SELECT Name FROM SYS.DATABASES WHERE name='QUANLYPHONGTRO')
	DROP DATABASE QUANLYPHONGTRO
GO
CREATE DATABASE QUANLYPHONGTRO
--ON(1E='QUANLYPHONGTRO_DEMO_1',FILE1E='C:\Program Files\Microsoft SQL Server\MSSQL10.CENTRALWALL\MSSQL\DATAQUANLYPHONGTRO_DEMO_1.MDF')
--LOG ON(1E='QUANLYPHONGTRO_DEMO_1',FILE1E='C:\Program Files\Microsoft SQL Server\MSSQL10.CENTRALWALL\MSSQL\DATAQUANLYPHONGTRO_DEMO_1.LDF')
GO
USE QUANLYPHONGTRO
GO

--CREATE TABLE USER_KHACHTHUE --Done
--(
--	UserID INT identity (1,1)PRIMARY KEY,
--	Username  nvarchar (25),
--	Pwd nvarchar(25),
--	IsAdmin int check (IsAdmin IN (1,0)) Default 0,
--	MaKhach varchar(5),
--	TenKhach nvarchar(30),
--	Email varchar(30), 
--	Phai nvarchar(5),
--	CMND varchar(11),
--	QueQuan nvarchar(20), 
--	NgheNghiep nvarchar(20),
--	DienThoai varchar(11),
--	TinhTrang int,
--)
--GO
CREATE TABLE KHACH_THUE --Done
(
	MaKhach varchar(5) primary key,
	TenKhach nvarchar(30),
	Phai nvarchar(5),
	CMND varchar(11),
	QueQuan nvarchar(50),
	NgheNghiep nvarchar(50)
)
GO
CREATE TABLE GIA_THUE --Như thực đơn, chỉ có loại phòng và giá phòng, tổng tiền = giá tiền + phụ thu * số người
(
	LoaiPhong nvarchar(50) primary key,
	PhuThu money, 
	GiaTien money
)
GO
CREATE TABLE PHONG_TRO 
(
	MaPhong varchar(5)primary key,
	TrangThai int check (TrangThai IN (1,0)) Default 0,
	LoaiPhong nvarchar(50),
	SoNguoi int
)
GO
CREATE TABLE CT_KHACH_THUE -- Ghi chú chứa thông tin yêu cầu dịch vụ của khách, sẽ được fill sau
(
	MaKhach varchar(5),
	MaPhong varchar(5),
	NgayVaoPhong datetime,	
	GhiChu nvarchar(50),
	primary key(MaKhach,MaPhong)
)
GO

--CREATE TABLE HOP_DONG --done
--(
	--MaHopDong int identity primary key,
	---NgayLap datetime,
	--MaPhong varchar(5),
	--MaKhach varchar(5)
--)
--go

CREATE TABLE HOA_DON --chưa dùng
(
	MaHoaDon int identity(1,1) primary key,
	NgayLap datetime,
	MaPhong varchar(5),
	MaKhach varchar(5),
	TongTien money
)
GO

CREATE TABLE DICH_VU
(
	MaDoAn varchar(5) primary key,
	TendoAn nvarchar(50),
	Gia money,
	TrangThai int check (TrangThai IN (1,0)) Default 0
)
GO

insert into DICH_VU values  ('DA001',N'Mì gói',18,1),
							('DA002',N'Bún cá',30,1),
							('DA003',N'Cơm tấm',27,1),
							('DA004',N'Snack',10,1)

CREATE TABLE CT_DICH_VU
(
	MaCTDichVu int identity(1,1) primary key,
	MaDoAn varchar(5),
	NgayDat datetime,
	MaPhong varchar(5),
	MaKhach varchar(5)
)
GO

CREATE TABLE THONG_BAO
(
	MaThongBao int identity(1,1) primary key,
	NoiDung nvarchar(250),
	NgayLap datetime
)
GO

set dateformat dmy
----PFK
--Alter table USER_KHACHTHUE add constraint FK_MK foreign key(MaKhach) references KHACH_THUE(MaKhach)

ALTER TABLE CT_KHACH_THUE
ADD CONSTRAINT FK_CTKHACHTHUE_KHACHTHUE FOREIGN KEY (MaKhach)
REFERENCES KHACH_THUE (MaKhach)
ON UPDATE CASCADE

--ALTER TABLE PHONG_TRO
--ADD CONSTRAINT FK_PHONGTRO_GIATHUE FOREIGN KEY (SoNguoi)
--REFERENCES GIA_THUE (SoNguoi)
--ON UPDATE CASCADE

/*ALTER TABLE CT_KHACH_THUE
Drop Constraint FK_CTKHACHTHUE_PHONGTRO
ADD CONSTRAINT FK_CTKHACHTHUE_PHONGTRO FOREIGN KEY (MaPhong)
REFERENCES PHONG_TRO (MaPhong)
ON UPDATE CASCADE*/

/*ALTER TABLE PHONG_TRO 
ADD CONSTRAINT FK_GIATHUE_PHONGTRO FOREIGN KEY (LoaiPhong)
REFERENCES GIA_THUE (LoaiPhong)
ON UPDATE CASCADE*/


/*ALTER TABLE HOA_DON
ADD CONSTRAINT FK_HOADON_PHONGTRO FOREIGN KEY (MaPhong)
REFERENCES PHONG_TRO (MaPhong)
ON UPDATE CASCADE
ALTER TABLE HOP_DONG
ADD CONSTRAINT FK_PHONGTRO_HOPDONG FOREIGN KEY (MaPhong)
REFERENCES PHONG_TRO (MaPhong)
ON UPDATE CASCADE*/
-----------------------------------------------------------------------------------------------------------------
GO
-----------------------------DATABASE-----------------------------
----ROLE
--INSERT ROLE_USER VALUES (111,'rwx')
--INSERT ROLE_USER VALUES (110,'rw')
--INSERT ROLE_USER VALUES (100,'r')

--GO
--KHACH_THUE

INSERT KHACH_THUE VALUES ('K01',N'Nguyễn Văn Tèo','Nam',281030001,N'Bình Định',N'Sinh viên')
INSERT KHACH_THUE VALUES ('K02',N'Mạc Thị Bưởi',N'Nữ',281030002,N'Bình Dương',N'Công nhân'	)
INSERT KHACH_THUE VALUES ('K03',N'Ô Văn Quen','Nam',281030003,N'Bình Dương',N'Sinh viên')
INSERT KHACH_THUE VALUES ('K04',N'Lao VănLực','Nam',281030004,N'TP.HCM',N'Sinh viên')
INSERT KHACH_THUE VALUES ('K05',N'Hành văn Chính','Nam',281030005,N'Bình Dương',N'Sinh viên')
INSERT KHACH_THUE VALUES ('K06',N'Kim Chi','Nam',281030008,N'Bình Định',N'Nhân viên')		
INSERT KHACH_THUE VALUES ('K07',N'Cường Văn Tráng','Nam',281030009,N'Bình Dương',N'Sinh viên')
INSERT KHACH_THUE VALUES ('K08',N'Võ Tòng','Nam',281030010,N'TP.HCM',N'Lái xe')
INSERT KHACH_THUE VALUES ('K09',N'Lâm Sung','Nam',281030011,N'Bình Định',N'Sinh viên')
INSERT KHACH_THUE VALUES ('K10',N'Tống Giang','Nam',281030012,N'TP.HCM',N'Sinh viên')		
INSERT KHACH_THUE VALUES ('K11',N'Quan Vũ','Nam',281030013,N'Bình Định',N'Sinh viên')		
INSERT KHACH_THUE VALUES ('K12',N'Lưu Bị','Nam',281030014,N'TP.HCM',N'Sinh viên')		
INSERT KHACH_THUE VALUES ('K13',N'Triệu Vân','Nam',281030015,N'Đồng Nai',N'Sinh viên')		
INSERT KHACH_THUE VALUES ('K14',N'Trương Phi','Nam',281030016,N'Đồng Nai',N'Công nhân')		
INSERT KHACH_THUE VALUES ('K15',N'Điêu Thuyền',N'Nữ',281030017,N'Bình Định',N'Công nhân')
INSERT KHACH_THUE VALUES ('K16',N'Tây Thi',N'Nữ',281030018,N'Đồng Tháp',N'Kế toán')
INSERT KHACH_THUE VALUES ('K17',N'Ngọc Trinh',N'Nữ',281030019,N'Đồng Nai',N'Phụ hồ')		
INSERT KHACH_THUE VALUES ('K18',N'Hà Trác Ngôn',N'Nữ',281030020,N'Lâm Đồng',N'Thợ may')		
INSERT KHACH_THUE VALUES ('K19',N'Lưu Diệc Phi',N'Nữ',281030021,N'Bình Thuận',N'Phụ hồ')		
INSERT KHACH_THUE VALUES ('K20',N'Lưu Văn Ban','Nam',281030022,N'Đồng Tháp',N'Công nhân')		
INSERT KHACH_THUE VALUES ('K21',N'Nguyễn Hữu Nam','Nam',281030023,N'TP.HCM',N'Sinh viên')
INSERT KHACH_THUE VALUES ('K22',N'Trần Văn Chất','Nam',281030024,N'Tiền Giang',N'Sinh viên')
INSERT KHACH_THUE VALUES ('K23',N'Nguyễn Văn D',N'Nữ',281030025,N'Kiên Giang',N'Sinh viên')
INSERT KHACH_THUE VALUES ('K24',N'Trần Thị B',N'Nữ',281030026,N'Bình Định',N'Kế toán')
INSERT KHACH_THUE VALUES ('K25',N'Nguyễn Thị E','Nam',281030027,N'TP.HCM',N'Sinh viên')		
INSERT KHACH_THUE VALUES ('K26',N'John','Nam',281030028,N'Nghệ An',N'Kinh Doanh')		
INSERT KHACH_THUE VALUES ('K27',N'Franky','Nam',281030029,N'Đồng Nai',N'IT')
INSERT KHACH_THUE VALUES ('K28',N'Ace','Nam',281030030,N'Quảng Nam',N'Sinh viên')		
INSERT KHACH_THUE VALUES ('K29',N'Nguyễn văn A',N'Nữ',281030031,N'Bạc Liêu',N'Công nhân')		
GO

--USER_KHACHTHUE
--INSERT USER_KHACHTHUE VALUES ('admin','admin',1,NULL)
--INSERT USER_KHACHTHUE VALUES ('user01','123456',0,'K01')
--INSERT USER_KHACHTHUE VALUES ('user02','123456',0,'K03')
--INSERT USER_KHACHTHUE VALUES ('user03','123456',0,'K04')
--INSERT USER_KHACHTHUE VALUES ('user04','123456',0,'K05')
--INSERT USER_KHACHTHUE VALUES ('user05','123456',0,'K07')
--INSERT USER_KHACHTHUE VALUES ('user06','123456',0,'K08')
--INSERT USER_KHACHTHUE VALUES ('user07','123456',0,'K09')
--INSERT USER_KHACHTHUE VALUES ('user08','123456',0,'K15')
--INSERT USER_KHACHTHUE VALUES ('user09','123456',0,'K21')
--INSERT USER_KHACHTHUE VALUES ('user10','123456',0,'K22')
--INSERT USER_KHACHTHUE VALUES ('user11','123456',0,'K23')
--INSERT USER_KHACHTHUE VALUES ('user12','123456',0,'K24')
--INSERT USER_KHACHTHUE VALUES ('user13','123456',0,'K27')
/*INSERT USER_KHACHTHUE VALUES ('admin','admin',1,NULL,	NULL,NULL,NULL,NULL,NULL,NULL,NULL,0)
INSERT USER_KHACHTHUE VALUES ('user01','123456',0,'K01',NULL,NULL,NULL,NULL,NULL,NULL,NULL,0)
INSERT USER_KHACHTHUE VALUES ('user02','123456',0,'K03',NULL,NULL,NULL,NULL,NULL,NULL,NULL,0)
INSERT USER_KHACHTHUE VALUES ('user03','123456',0,'K04',NULL,NULL,NULL,NULL,NULL,NULL,NULL,0)
INSERT USER_KHACHTHUE VALUES ('user04','123456',0,'K05',NULL,NULL,NULL,NULL,NULL,NULL,NULL,0)
INSERT USER_KHACHTHUE VALUES ('user05','123456',0,'K07',NULL,NULL,NULL,NULL,NULL,NULL,NULL,0)
INSERT USER_KHACHTHUE VALUES ('user06','123456',0,'K08',NULL,NULL,NULL,NULL,NULL,NULL,NULL,0)
INSERT USER_KHACHTHUE VALUES ('user07','123456',0,'K09',NULL,NULL,NULL,NULL,NULL,NULL,NULL,0)
INSERT USER_KHACHTHUE VALUES ('user08','123456',0,'K15',NULL,NULL,NULL,NULL,NULL,NULL,NULL,0)
INSERT USER_KHACHTHUE VALUES ('user09','123456',0,'K21',NULL,NULL,NULL,NULL,NULL,NULL,NULL,0)
INSERT USER_KHACHTHUE VALUES ('user10','123456',0,'K22',NULL,NULL,NULL,NULL,NULL,NULL,NULL,0)
INSERT USER_KHACHTHUE VALUES ('user11','123456',0,'K23',NULL,NULL,NULL,NULL,NULL,NULL,NULL,0)
INSERT USER_KHACHTHUE VALUES ('user12','123456',0,'K24',NULL,NULL,NULL,NULL,NULL,NULL,NULL,0)
INSERT USER_KHACHTHUE VALUES ('user13','123456',0,'K27',NULL,NULL,NULL,NULL,NULL,NULL,NULL,0)
INSERT USER_KHACHTHUE VALUES ('user14','123456',0,NULL,'Vô danh','email@yahoo.com','Nam','1235699','TPHCM','IT','58852',1)
*/

--PHONG_TRO
/*INSERT GIA_THUE VALUES (1,500000)
INSERT GIA_THUE VALUES (2,1000000)
INSERT GIA_THUE VALUES (3,1500000)
INSERT GIA_THUE VALUES (4,1700000)
INSERT GIA_THUE VALUES (5,2000000)*/

INSERT PHONG_TRO VALUES ('A101',0,	N'Ngắn hạn',	NULL)	
INSERT PHONG_TRO VALUES ('A102',0,	N'Ngắn hạn',	NULL)	
INSERT PHONG_TRO VALUES ('A103',0,	N'Ngắn hạn',	NULL)	
INSERT PHONG_TRO VALUES ('A104',0,	N'Ngắn hạn',	NULL)	
INSERT PHONG_TRO VALUES ('A105',0,	N'Ngắn hạn',	NULL)		
INSERT PHONG_TRO VALUES ('B101',0,	N'Dài hạn',	0)	
INSERT PHONG_TRO VALUES ('B102',0,	N'Dài hạn',	0)	
INSERT PHONG_TRO VALUES ('B103',0,	N'Dài hạn',	0)		
INSERT PHONG_TRO VALUES ('B104',0,	N'Dài hạn',	0)	
INSERT PHONG_TRO VALUES ('B105',0,	N'Dài hạn',	0)	
INSERT PHONG_TRO VALUES ('B106',0,	N'Dài hạn',	0)	
INSERT PHONG_TRO VALUES ('B107',0,	N'Dài hạn',	0)	
INSERT PHONG_TRO VALUES ('A106',0,	N'Ngắn hạn',	NULL)		
INSERT PHONG_TRO VALUES ('A107',0,	N'Ngắn hạn',	NULL)	
INSERT PHONG_TRO VALUES ('A108',0,	N'Ngắn hạn',	NULL)	
INSERT PHONG_TRO VALUES ('A109',0,	N'Ngắn hạn',	NULL)	
INSERT PHONG_TRO VALUES ('B111',0,	N'Dài hạn',	NULL)	
INSERT PHONG_TRO VALUES ('B108',0,	N'Dài hạn',	NULL)	
INSERT PHONG_TRO VALUES ('B109',0,	N'Dài hạn',	NULL)	
INSERT PHONG_TRO VALUES ('B110',0,	N'Dài hạn',	NULL)	

INSERT INTO GIA_THUE VALUES (N'Dài hạn', 150, 1500),
							(N'Ngắn hạn', 20, 200)

GO
--CT_KHACH_THUE
/*set dateformat dmy
INSERT CT_KHACH_THUE VALUES ('K01', N'NHB','A101',12/03/2019,150,01864787677)
INSERT CT_KHACH_THUE VALUES ('K02', N'NHB', 'A101',15/02/2018,123,01458)
INSERT CT_KHACH_THUE VALUES ('K03',N'NHB' ,'A101',14/01/2011,456,1478)
INSERT CT_KHACH_THUE VALUES ('K04',N'NHB', 'A102',20/02/2018,120,012545)
INSERT CT_KHACH_THUE VALUES ('K05',N'NHB', 'A102',21/05/2014,140,01478)
INSERT CT_KHACH_THUE VALUES ('K06',N'NHB', 'A102',22/01/2011,789,147895)
INSERT CT_KHACH_THUE VALUES ('K07',N'NHB', 'A103',11/01/2017,111,01245)
INSERT CT_KHACH_THUE VALUES ('K08',N'NHB', 'A103',12/05/2013,210,01478)
INSERT CT_KHACH_THUE VALUES ('K09',N'HB', 'A104',17/08/2018,220,0147)
INSERT CT_KHACH_THUE VALUES ('K10',N'NC','A105',10/01/2011,260,01456)
INSERT CT_KHACH_THUE VALUES ('K11',N'NHB','A105',25/05/2014,170,01456)
INSERT CT_KHACH_THUE VALUES ('K12',N'NHB' 'A106',17/05/2014,160,01245)
INSERT CT_KHACH_THUE VALUES ('K13', 'A106',NULL)
INSERT CT_KHACH_THUE VALUES ('K14', 'A107',NULL)
INSERT CT_KHACH_THUE VALUES ('K15', 'A107',NULL)Msg 213, Level 16, State 1, Line 184
Column name or number of supplied values does not match table definition.
INSERT CT_KHACH_THUE VALUES ('K16', 'A107',NULL)
INSERT CT_KHACH_THUE VALUES ('K17', 'A108',NULL)
INSERT CT_KHACH_THUE VALUES ('K18', 'A108',NULL)
INSERT CT_KHACH_THUE VALUES ('K19', 'A108',NULL)
INSERT CT_KHACH_THUE VALUES ('K20', 'A109',NULL)
INSERT CT_KHACH_THUE VALUES ('K21', 'A109',NULL)
INSERT CT_KHACH_THUE VALUES ('K22', 'A109',NULL)
INSERT CT_KHACH_THUE VALUES ('K23', 'A110',NULL)
INSERT CT_KHACH_THUE VALUES ('K24', 'A110',NULL)
INSERT CT_KHACH_THUE VALUES ('K25', 'A110',NULL)
INSERT CT_KHACH_THUE VALUES ('K26', 'A110',NULL)
INSERT CT_KHACH_THUE VALUES ('K27', 'B101',NULL)
INSERT CT_KHACH_THUE VALUES ('K28', 'B101',NULL)
INSERT CT_KHACH_THUE VALUES ('K29', 'B102',NULL)
*/
GO
---GT

--Hóa đơn
/*set dateformat dmy
insert into HOA_DON values('1/4/2013','A101','K01',N'NHB',2,'')
insert into HOA_DON values('1/7/2013','A102','K04',N'NV',3,'')
insert into HOA_DON values('1/10/2013','A103','K07',N'HB',1,'')
insert into HOA_DON values('1/5/2013','A104','K09',N'NV',6,'')
insert into HOA_DON values('1/6/2013','A105','K10',N'BTT',5,'')
insert into HOA_DON values('1/4/2013','A106','K06',N'NHB',1)
insert into HOA_DON values('1/4/2013','A107','K07',N'NHB',8)
insert into HOA_DON values('1/4/2013','A108','K08',N'NV',9)
insert into HOA_DON values('1/4/2013','A109','K09',N'NC',10)
insert into HOA_DON values('1/4/2013','A110','K10',N'NTT',11)
insert into HOA_DON values('1/4/2013','B101')
--insert into HOA_DON values('1/4/2013','B102')
go*/
---------------------------------------------------------------------------Procedure-------------------------------
--Thêm khách thuê

create proc ThemKhachThue
(
@makhach varchar(5),
@tenkhach nvarchar(30),
@phai nvarchar(5),
@cmnd varchar(15),
@quequan nvarchar(30),
@nghenghiep nvarchar(30)
)
as
	begin
	
			insert into KHACH_THUE values(@makhach,@tenkhach,@phai,@cmnd,@quequan,@nghenghiep)
		end

go

--Xóa khách thuê
create proc XoaKhach
(
@makhach varchar(5),
@taikhoan varchar(25)
)
as
	begin
	--nếu như khách không có tài khoản và chưa thuê phòng
	if(@taikhoan IS NULL AND NOT EXISTS(select @makhach from CT_KHACH_THUE where @makhach = MaKhach))
			begin
				delete from KHACH_THUE where MaKhach = @makhach
			end
		else
	--nếu như khách không có tài khoản và đã thuê phòng
	if(@taikhoan IS NULL AND EXISTS(select @makhach from CT_KHACH_THUE where @makhach = MaKhach))
			begin
				delete from CT_KHACH_THUE where MaKhach = @makhach
				delete from KHACH_THUE where MaKhach = @makhach
			end
	--nếu khách có tài khoản và chưa thuê phòng
	if(@taikhoan IS NOT NULL AND NOT EXISTS(select @makhach from CT_KHACH_THUE where @makhach = MaKhach))
		begin
			delete from USER_KHACHTHUE where MaKhach = @makhach
			delete from KHACH_THUE where MaKhach = @makhach
		end
	--nếu khách có tài khoản và đã thuê phòng
	if(@taikhoan IS NOT NULL AND EXISTS(select @makhach from CT_KHACH_THUE where @makhach = MaKhach))
		begin
			delete from CT_KHACH_THUE where MaKhach = @makhach
			delete from USER_KHACHTHUE where MaKhach = @makhach
			delete from KHACH_THUE where MaKhach = @makhach
		end
	end
go

--Sửa khách thuê
create proc SuaKhachThue
(
	@makhach varchar(5),
	@tenkhach nvarchar(30),
	@phai nvarchar(5),
	@cmnd varchar(15),
	@quequan nvarchar(30),
	@nghenghiep nvarchar(30)
)
as
	begin
		update KHACH_THUE
		set TenKhach = @tenkhach,
			Phai = @phai,
			CMND = @cmnd,
			QueQuan = @quequan,
			NgheNghiep = @nghenghiep
		where MaKhach = @makhach
	end
go
---Bảng giá phòng trọ
--Thêm phòng

--Sửa giá tiền

create proc SuaPhong
(
	@songuoi int,
	@giatien money
)
as
	begin
		update PHONG_TRO
		set GiaThue = @giatien
		where SoNguoi =@songuoi
	end
go

create proc ThemPhong
(
	@songuoi int,
	@giatien money
)
as
	begin
		insert into GIA_THUE values(@songuoi,@giatien)
	end
go
--Thêm khách thuê vào ở ghép
set dateformat dmy
go

--Khi khách thuê vào ở ghép thì ta phải cập nhật lại số người bên PHONG_TRO
drop procedure if exists dbo.ThemKhachThueVaooGhep
create proc ThemKhachThueVaooGhep
(
	@MaKhach varchar(5),
	@MaPhong varchar(5),
	@NgayVaoPhong datetime,
	@GhiChu nvarchar(50)
)
as
	begin
		insert into CT_KHACH_THUE values(@MaKhach,@MaPhong,@NgayVaoPhong,@GhiChu)
		update PHONG_TRO set SoNguoi+=1, TrangThai = 1 where MaPhong = @MaPhong
	end
	go
go
--Thêm khách thuê vào phòng mới
--Khi khách thuê vào ở mới thì ta phải cập nhật lại số người bên PHONG_TRO
drop procedure if exists dbo.ThemKhachThueVaoPhongMoi
create proc ThemKhachThueVaoPhongMoi
(
	@MaKhach varchar(5),
	@MaPhong varchar(5),
	@NgayVaoPhong datetime,
	@GhiChu nvarchar(50)
)
as
	begin
		--insert into HOP_DONG values(convert(varchar(10),@NgayVaoPhong,103),@MaPhong)
		insert into CT_KHACH_THUE values(@MaKhach,@MaPhong,@NgayVaoPhong,@GhiChu)
		update PHONG_TRO set SoNguoi=1, TrangThai = 1 where MaPhong = @MaPhong
	end
go
-----Khách Checkout
drop procedure if exists dbo.KhachCheckout
create proc KhachCheckout
(
	@MaPhong varchar(5)
)
as
	begin
		delete CT_KHACH_THUE where MaPhong = @MaPhong
		update PHONG_TRO set SoNguoi=0, TrangThai = 0 where MaPhong = @MaPhong
		delete CT_DICH_VU where MaPhong = @MaPhong
		
	end
go


--Thêm mới hóa đơn và chi tiết hóa đơn
--Thêm mới hóa đơn
create proc ThemHoaDon
(
	@MaHoaDon int,
	@NgayLap datetime,
	@MaPhong varchar(5),
	@MaKhach varchar(5),
	@TenKhach nvarchar(30),
	@Thang int,
	@TongTien money
)
as
	begin
		insert into HOA_DON values(convert(varchar(10),@ngaylap,103), @MaPhong,@MaKhach,@TenKhach,@Thang,@TongTien)
	end
	
go
--Thêm mới chi tiết hóa đơn
--Xóa hóa đơn và chi tiết hóa đơn
create proc XoaHoaDon
(
	@mahoadon int
)
as
	begin
		delete from HOA_DON where @mahoadon = MaHoaDon
	end
go
------- thong tin dich vu
--Sửa dịch vụ
---- xóa dv

--Đổi mật khẩu ADMIN

--bonus


--create proc ThemKhachDatPhong
--(
	
--)
--as
--	begin
--		insert into KHACH_THUE values()
--	end
select * from CT_KHACH_THUE
select * from PHONG_TRO