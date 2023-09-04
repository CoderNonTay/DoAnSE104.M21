
CREATE DATABASE QLTS
USE QLTS

--DROP DATABASE QLTS

SET DATEFORMAT DMY

-- PHAN TAO BANG

CREATE TABLE NGUOIDUNG
(
TenDangNhap nvarchar(20) COLLATE Latin1_General_CS_AS PRIMARY KEY, 
MatKhau nvarchar(20) COLLATE Latin1_General_CS_AS
);

CREATE TABLE PHIEUBANHANG
(
SoPBH int PRIMARY KEY IDENTITY, -- Dinh danh 
NgayLapPBH date,
MaKH int NOT NULL
);

CREATE TABLE CT_PBH
(
MaCT_PBH int PRIMARY KEY identity(1050000,1),
SoPBH int, -- >0, Khoa ngoai den PHIEUBANHANG
MaSP int NOT NULL,
SoLuongSP tinyint NOT NULL,
ThanhTien money NOT NULL -- >0
);

CREATE TABLE SANPHAM 
(
MaSP int PRIMARY KEY identity(1020000,1),
TenSP nvarchar(40) UNIQUE,
MaLoaiSP int NOT NULL, -- Khoa ngoai  den LOAISP
DonGiaMuaVao MONEY DEFAULT(0),
DonGiaBanRa MONEY DEFAULT(0)
);

CREATE TABLE LOAISP
(
MaLoaiSP int PRIMARY KEY identity(1030000,1),
TenLoaiSP nvarchar(30) UNIQUE,
MaDVT int NOT NULL, -- Khoa ngoai den table DVT
LoiNhuan float NOT NULL  
);

CREATE TABLE DVT 
(
MaDVT int PRIMARY KEY identity(1040000,1),
TenDVT nvarchar(10) UNIQUE
);

CREATE TABLE PHIEUMUAHANG 
(
SoPMH int PRIMARY KEY IDENTITY, -- >0
NgayLapPMH date NOT NULL,
MaNCC int NOT NULL -- Khoa ngoai den table NhaCungCap
);

CREATE TABLE CT_PMH 
(
MaCT_PMH int PRIMARY KEY identity(1000000,1),
SoPMH int, -->0 Khoa ngoai den table PHIEUMUAHANG
MaSP int NOT NULL, -- Khoa ngoai den table SANPHAM
SoLuongSP tinyint NOT NULL,
ThanhTien MONEY NOT NULL -- >0
);

CREATE TABLE NHACUNGCAP
(
MaNCC int PRIMARY KEY identity(1010000,1),
NhaCungCap nvarchar(40) NOT NULL,
DiaChiNCC nvarchar(40) NOT NULL,
SDT_NCC varchar(12) NOT NULL UNIQUE
);

CREATE TABLE BAOCAO
(
MaBC int PRIMARY KEY identity(1090000,1),
Thang int not null, -->0 <13
Nam int not null
);

CREATE TABLE CT_BAOCAO
(
MaCT_BaoCao int PRIMARY KEY identity(1100000,1),
MaBC int not null,
MaSP int not null,
TonDau smallint DEFAULT(0),
TonCuoi smallint DEFAULT(0),
SoLuongMuaVao smallint DEFAULT(0),
SoLuongBanRa smallint DEFAULT(0)
);

CREATE TABLE KHACHHANG
(
MaKH int PRIMARY KEY identity(1060000,1),
KhachHang nvarchar(40) NOT NULL,
SDT_KhachHang varchar(12) NOT NULL UNIQUE
);  

CREATE TABLE PHIEUDICHVU
(
SoPDV int PRIMARY KEY identity, -- >0
NgayLapPDV date Not NULL,
MaKH int NOT NULL, -- Khoa ngoai den table KHACHHANGBAOCAO
TongTien MONEY NOT NULL, -- >0
TraTruoc MONEY NOT NULL, -- >0
TraSau MONEY NOT NULL, -- >0
TinhTrangPDV nvarchar(20) DEFAULT(N'Hoàn thành') NOT NULL -- Hoan thanh hoac chua hoan thanh  
);

CREATE TABLE CT_PDV
(
MaCT_PDV int PRIMARY KEY identity(1070000,1), -- >0
SoPDV int,  -- Khoa ngoai den table PHIEUDICHVU
MaLoaiDV int  Not NULL, -- Khoa ngoai den table LOAIDICHVU
ChiPhiRieng MONEY, -- >=0
DonGiaDuocTinh MONEY NOT NULL, -- >0 hoac >=0 
SoLuong tinyint NOT NULL, -- >0
ThanhTien MONEY NOT NULL, -- >0 
ThanhToanTruoc MONEY NOT NULL, -- >=PhanTramTraTruoc*ThanhTien  
ThanhTienSau MONEY NOT NULL, -- >=0 
NgayGiao date, -- >=NgayLapPDV 
TinhTrang nvarchar(20) NOT NULL -- Da giao hoac chua giao   
);  

CREATE TABLE LOAIDICHVU
(
MaLoaiDV int PRIMARY KEY identity(1080000,1),
TenLoaiDV nvarchar(30) NOT NULL UNIQUE,
DonGiaDV MONEY NOT NULL -- >0    
)

CREATE TABLE THAMSO 
(
PhanTramTraTruoc FLOAT NOT NULL   
);

-- PHAN TAO KHOA NGOAI

ALTER TABLE PHIEUBANHANG ADD
CONSTRAINT FK_PBH_MaKH FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)

ALTER TABLE CT_PBH ADD 
CONSTRAINT FK_CTPBH_SoPBH FOREIGN KEY (SoPBH) REFERENCES PHIEUBANHANG(SoPBH),
CONSTRAINT FK_PBH_MaSP FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP)

ALTER TABLE SANPHAM ADD
CONSTRAINT FK_SP_LoaiSP FOREIGN KEY (MaLoaiSP) REFERENCES LOAISP(MaLoaiSP)

ALTER TABLE LOAISP ADD
CONSTRAINT FK_DVT_MaDVT FOREIGN KEY (MaDVT) REFERENCES DVT(MaDVT)

ALTER TABLE PHIEUMUAHANG ADD
CONSTRAINT FK_PMH_MaNCC FOREIGN KEY (MaNCC) REFERENCES NHACUNGCAP(MaNCC)

ALTER TABLE CT_PMH ADD
CONSTRAINT FK_CTPMH_SoPMH FOREIGN KEY (SoPMH) REFERENCES PHIEUMUAHANG(SoPMH),
CONSTRAINT FK_CTPMH_MaSP FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP)

ALTER TABLE PHIEUDICHVU ADD
CONSTRAINT FK_PDV_MaKH FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)

ALTER TABLE CT_PDV ADD
CONSTRAINT FK_CTPDV_SoPDV FOREIGN KEY (SoPDV) REFERENCES PHIEUDICHVU(SoPDV),
CONSTRAINT FK_CTPDV_MaLoaiDV FOREIGN KEY (MaLoaiDV) REFERENCES LOAIDICHVU(MaLoaiDV)

ALTER TABLE CT_BAOCAO ADD
CONSTRAINT FK_CTBC_MaBC FOREIGN KEY (MaBC) REFERENCES BAOCAO(MaBC),
CONSTRAINT FK_CTBC_MaSP FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP)

Go
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
IF @strInput IS NULL 
RETURN @strInput 
IF @strInput = '' 
RETURN @strInput 
DECLARE @RT NVARCHAR(4000) 
DECLARE @SIGN_CHARS NCHAR(136) 
DECLARE @UNSIGN_CHARS NCHAR (136) 
SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
DECLARE @COUNTER int 
DECLARE @COUNTER1 int 
SET @COUNTER = 1 
WHILE (@COUNTER <=LEN(@strInput)) 
BEGIN 
SET @COUNTER1 = 1 
WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
BEGIN 
IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
BEGIN 
IF @COUNTER=1 
SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
ELSE 
SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
BREAK 
END 
SET @COUNTER1 = @COUNTER1 +1 
END 
SET @COUNTER = @COUNTER +1 
END 
SET @strInput = replace(@strInput,' ','-') 
RETURN @strInput 
END





--PHAN NHAP DU LIEU







INSERT INTO NGUOIDUNG VALUES ('user1','123456')

INSERT INTO THAMSO values(50) -- Mac dinh phan tram tra truoc la 50%


Go
CREATE PROC CapNhatThamSo  -- Nhap du lieu bang tham so
@phantramtratruoc float
as
begin
UPDATE THAMSO SET PhanTramTraTruoc = @phantramtratruoc
end


Go
CREATE PROC NhapDVT -- Nhap don vi tinh
@tendvt nvarchar(10)
as
begin
insert into DVT(TenDVT) values(@tendvt)
end



Go
CREATE PROC NhapLoaiSP -- Nhap loai san pham
@tenloaisp nvarchar(30), @madvt int, @loinhuan float
as
begin
insert into LOAISP(TenLoaiSP,MaDVT,LoiNhuan) values(@tenloaisp,@madvt,@loinhuan)
end

Go
CREATE PROC NhapSP -- Nhap du lieu SANPHAM
@maloaisp int, @tensp nvarchar(40)
as
begin
insert into SANPHAM(TenSP,MaLoaiSP) values (@tensp,@maloaisp)
end

Go
CREATE PROC NhapNCC -- Nhap du lieu NHACUNGCAP
@tennhacungcap nvarchar(40), @diachi nvarchar(40), @sdt varchar(12)
as
begin
insert into NHACUNGCAP(NhaCungCap, DiaChiNCC, SDT_NCC) values (@tennhacungcap, @diachi, @sdt)
end 

Go
CREATE PROC NhapPMH -- Nhap du lieu cho PMH
@mancc int
as
begin
declare @ngay date
set @ngay = getdate()
insert into PHIEUMUAHANG(NgayLapPMH,MaNCC) values (@ngay,@mancc)
end

Go
CREATE PROC NhapChiTietPMH -- Nhap du lieu cho CTPMH
@sopmh int, @masp int, @soluongsp tinyint, @thanhtien money
as
begin
insert into CT_PMH(SoPMH,MaSP,SoLuongSP,ThanhTien) values (@sopmh,@masp,@soluongsp,@thanhtien)
end

Go 
CREATE PROC NhapKH -- Nhap du lieu KHACHHANG
@tenkhachhang nvarchar(40), @sdt varchar(12)
as
begin
insert into KHACHHANG(KhachHang,SDT_KhachHang) values(@tenkhachhang,@sdt)
end

Go
CREATE  PROC NhapPBH -- Nhap du lieu PHIEUBANHANG 
@makh int
as
begin
declare @ngay date
set @ngay = getdate()
insert into PHIEUBANHANG(NgayLapPBH, MaKH) values (@ngay, @makh)
end

Go
CREATE PROC NhapCT_PBH -- Nhap du lieu cho bang CT_PBH
@sopbh int, @masp int, @soluongsp tinyint, @thanhtien money
as
begin
insert into CT_PBH(SoPBH,MaSP,SoLuongSP,ThanhTien) values (@sopbh,@masp,@soluongsp,@thanhtien)
end


Go
CREATE PROC Nhap_CTBC -- Nhap du lieu cho bang CTBC ( nhap cho phan admin )
@mabc int, @masp int
as
begin
insert into CT_BAOCAO(MaBC,MaSP) values(@mabc,@masp)
end

--DROP PROC Nhap_CTBC

Go
CREATE PROC Nhap_LoaiDV -- Nhap du lieu cho bang LOAIDICHVU
@tenloaidv nvarchar(30), @dongiadv money
as
begin
insert into LOAIDICHVU(TenLoaiDV,DonGiaDV) values (@tenloaidv,@dongiadv)
end

Go
CREATE PROC Nhap_PhieuDV -- Nhap PDV
@makh int, @tongtien money, @tratruoc money, @trasau money
as
begin
declare @ngaylap date
set @ngaylap = GETDATE()
insert into PHIEUDICHVU(NgayLapPDV, MaKH, TongTien, TraTruoc, TraSau) values (@ngaylap,@makh,@tongtien, @tratruoc,@trasau)
end

Go
CREATE PROC Nhap_CTPDV -- Nhap CTPDV
@sophieu int, @maloaidv int, @chiphirieng money, @dongiaduoctinh money, @soluong tinyint, @thanhtien money, @thanhtoantruoc money, @thanhtoansau money, @ngaygiao NVARCHAR(12), @tinhtrang nvarchar(20)
as
begin
declare @tinhtrangpdv nvarchar(20), @ngay nvarchar(12)
set @ngay = Convert(Date,@ngaygiao, 103)
if (select TinhTrangPDV from PHIEUDICHVU where SoPDV=@sophieu) = N'Hoàn thành'
begin
if @tinhtrang = N'Chưa giao'
begin
update PHIEUDICHVU set TinhTrangPDV=N'Chưa hoàn thành' where SoPDV=@sophieu
end
end
insert into CT_PDV(SoPDV,MaLoaiDV,ChiPhiRieng,DonGiaDuocTinh,SoLuong,ThanhTien,ThanhToanTruoc,ThanhTienSau,NgayGiao,TinhTrang) values (@sophieu, @maloaidv, @chiphirieng, @dongiaduoctinh, @soluong,@thanhtien,@thanhtoantruoc,@thanhtoansau,@ngay,@tinhtrang)
end







-- PHAN UPDATE/
Go
CREATE PROC UpdateLoaiSanPham -- cap nhat bang loai sp ten hoac loi nhuan
@maloaisp int, @tenloaisp nvarchar(30), @loinhuan float
as
begin 
update LOAISP set TenLoaiSP=@tenloaisp, LoiNhuan=@loinhuan where @maloaisp = MaLoaiSP
declare @dongiabanra money, @dongiamuavao money
set @dongiamuavao = (select DonGiaMuaVao from SANPHAM where MaLoaiSP = @maloaisp )
set @dongiabanra = @dongiamuavao + @dongiamuavao*((select LoiNhuan from LOAISP where @maloaisp = MaLoaiSP)/100)
update SANPHAM set DonGiaBanRa = @dongiabanra where MaLoaiSP = @maloaisp
end


Go
CREATE PROC UpdateSanPham -- cap nhat ten san pham, doi loai san pham cho san pham do
@masp int, @tensp nvarchar(40), @maloaisp int
as
begin
update SANPHAM set TenSP=@tensp, MaLoaiSP=@maloaisp where MaSP=@masp
end

Go
CREATE PROC DonGiaMua -- cap nhat lai don gia mua neu co thay doi
@masp int, @dongiamua money
as
begin
update SANPHAM set DonGiaMuaVao=@dongiamua where MaSP=@masp
declare @dongiabanra money, @dongiamuavao money
set @dongiamuavao = (select DonGiaMuaVao from SANPHAM where MaSP=@masp )
set @dongiabanra = @dongiamuavao + @dongiamuavao*((select LoiNhuan from LOAISP,SANPHAM where MaSP=@masp AND SANPHAM.MaLoaiSP=LOAISP.MaLoaiSP)/100)
update SANPHAM set DonGiaBanRa = @dongiabanra where MaSP=@masp
end


Go
CREATE PROC UpdateKhachHang -- cap nhat lai sdt bang khach hang
@makh int, @sdt_khachhang int
as
begin
update KHACHHANG set SDT_KhachHang = @sdt_khachhang where MaKH = @makh
end

Go
CREATE PROC UpdateNCC -- cap nhat nha cung cap
@mancc int, @tennhacungcap nvarchar(40), @sdt varchar(12), @diachi nvarchar(40)
as
begin
update NHACUNGCAP set NhaCungCap=@tennhacungcap, DiaChiNCC=@diachi, SDT_NCC=@sdt where MaNCC=@mancc
end

Go
CREATE PROC UpdateDonGiaDV -- cap nhat ten loai dich vu va don gia
@maloaidv int, @tenloaidv nvarchar(30), @dongiadv money
as
begin
update LOAIDICHVU set TenLoaiDV=@tenloaidv, DonGiaDV = @dongiadv where MaLoaiDV=@maloaidv
end


Go
CREATE PROC Update_CTBCforNhap -- Update du lieu nhap hang cho bang CTBC 
@tensp nvarchar(40), @soluongmuavao smallint
as
begin
declare @muavao smallint, @masanpham int, @machitietbaocao int, @time date;
set @masanpham = (select MaSP from SANPHAM where @tensp = TenSP)
set @time = GETDATE();
set @machitietbaocao = ( SELECT MaCT_BaoCao from CT_BAOCAO, BAOCAO where Thang = MONTH(@time) and Nam = YEAR(@time) and BAOCAO.MaBC = CT_BAOCAO.MaBC AND MaSP = @masanpham )
set @muavao = (select SoLuongMuaVao from CT_BAOCAO where MaCT_BaoCao= @machitietbaocao)
update CT_BAOCAO set SoLuongMuaVao=@soluongmuavao+@muavao, TonCuoi=TonDau+@soluongmuavao+@muavao-SoLuongBanRa where MaCT_BaoCao=@machitietbaocao
end

Go
CREATE PROC Update_CTBCforBan -- Update du lieu ban ra cho bang CTBC 
@tensp nvarchar(40), @soluongbanra smallint
as
begin
declare @banra smallint, @masanpham int, @machitietbaocao int, @time date;
set @masanpham = (select MaSP from SANPHAM where @tensp = TenSP)
set @time = GETDATE();
set @machitietbaocao = ( SELECT MaCT_BaoCao from CT_BAOCAO, BAOCAO where Thang = MONTH(@time) and Nam = YEAR(@time) and BAOCAO.MaBC = CT_BAOCAO.MaBC AND MaSP = @masanpham )
set @banra = (select SoLuongBanRa from CT_BAOCAO where MaCT_BaoCao= @machitietbaocao)
update CT_BAOCAO set SoLuongBanRa=@soluongbanra+@banra, TonCuoi=TonDau+SoLuongMuaVao-@soluongbanra-@banra where MaCT_BaoCao=@machitietbaocao
end


GO
CREATE PROC UpdateTinhTrangDV --cap nhat tinh trang dich vu
@maCT_PDV INT, @tinhtrang NVARCHAR(12)
AS
BEGIN
UPDATE dbo.CT_PDV SET TinhTrang = @tinhtrang WHERE MaCT_PDV = @maCT_PDV
END



Go
CREATE PROC Update_TinhTrangPDV -- update tinh trang phieu dich vu
@sophieu int
as
begin
declare @count int;
set @count = (select COUNT(MaCT_PDV) from CT_PDV where SoPDV=@sophieu and TinhTrang=N'Chưa giao')
if @count=0
update PHIEUDICHVU set TinhTrangPDV=N'Hoàn thành' where SoPDV=@sophieu
else 
update PHIEUDICHVU set TinhTrangPDV=N'Chưa hoàn thành' where SoPDV=@sophieu
end

GO
CREATE PROC UpdateNgayGiao -- update ngay giao
@ngaygiao NVARCHAR(12), @maCT INT
AS
BEGIN
DECLARE @time DATE
SET @time = CONVERT(DATE, @ngaygiao, 101)
UPDATE dbo.CT_PDV SET NgayGiao = @time WHERE MaCT_PDV = @maCT
END








-- PHAN KIEM TRA LOGIN

Go
CREATE PROC Login
@username nvarchar(20), @pass varchar(20)
as 
begin
select * from NGUOIDUNG where TenDangNhap=@username and MatKhau=@pass
end

Go 
CREATE PROC KT_BC  -- Tu dong nhap khi qua thang moi
as
begin
declare @time date, @mabc int;
set @time = getdate();
if not exists(select MaBC from BAOCAO where Thang=MONTH(@time) and Nam=Year(@time))
begin
insert into BAOCAO(Thang,Nam) values(MONTH(@time),Year(@time))
set @mabc= (select MaBC from BAOCAO where Thang=MONTH(@time) and Nam=Year(@time))
insert into CT_BAOCAO(MaBC,MaSP,TonDau,TonCuoi,SoLuongMuaVao,SoLuongBanRa) 
select MaBC + 1, MaSP, TonCuoi,TonCuoi,0,0
from CT_BAOCAO
where CT_BAOCAO.MaBC = @mabc-1
end
end



-- PHAN HIEN THI

Go
CREATE PROC HienThiDanhSachPhieuDichVu -- Hien thi danh sach phieu dich vu
@sophieu int, @makh int, @tinhtrang nvarchar(20), @ngaylap date
AS
begin
SELECT SoPDV as 'Số phiếu', NgayLapPDV as 'Ngày lập', KhachHang as 'Khách hàng', TongTien as 'Tổng tiền', TraTruoc as 'Trả trước', TraSau as 'Còn lại', TinhTrangPDV as 'Đơn vị tính'
From PHIEUDICHVU, KHACHHANG
WHERE  SoPDV=@sophieu and KHACHHANG.MaKH=@makh and  TinhTrangPDV = @tinhtrang and NgayLapPDV = @ngaylap
end 




Go
CREATE PROC HienThiBaoCaoTonKho -- Hien thi bao cao ton kho
@thang int, @nam int
AS;
begin
SELECT TenSP as 'Sản phẩm', TonDau as 'Tồn đầu', SoLuongMuaVao as 'Số lượng mua vào', SoLuongBanRa as 'Số lượng bán ra', TonCuoi as 'Tồn cuối', TenDVT as 'Đơn vị tính' 
FROM CT_BAOCAO, BAOCAO, DVT, LOAISP, SANPHAM
WHERE Thang=@thang and Nam=@nam and BAOCAO.MaBC=CT_BAOCAO.MaBC and CT_BAOCAO.MaSP = SANPHAM.MaSP and SANPHAM.MaLoaiSP=LOAISP.MaLoaiSP and LOAISP.MaDVT=DVT.MaDVT 
end



-- PHAN LAY DU LIEU TU SQL
Go
CREATE PROC GetMaKHByTenKH -- lay ma khach hang
@tenkh nvarchar(40)
AS
begin
SELECT *
From KHACHHANG
WHERE KhachHang=@tenkh
end

Go
CREATE PROC GetMaLoaiDVByTenLoaiDV -- lay ma loai
@tendv nvarchar(30)
AS
begin
SELECT *
From LOAIDICHVU
WHERE TenLoaiDV=@tendv
end

GO
CREATE PROC GetCTPDVFromPDV -- Lay de hien thi ctpdv
@SoPDV INT
AS
BEGIN
SELECT TenLoaiDV, DonGiaDV, ChiPhiRieng, DonGiaDuocTinh, SoLuong, ThanhTien, ThanhToanTruoc, ThanhTienSau, NgayGiao, TinhTrang
FROM dbo.CT_PDV, dbo.LOAIDICHVU
WHERE dbo.CT_PDV.MaLoaiDV = dbo.LOAIDICHVU.MaLoaiDV AND SoPDV = @SoPDV
END







-- PHAN INSERT DU LIEU
EXEC NhapDVT N'Chiếc'
EXEC NhapDVT N'Cái'
SELECT * FROM DVT

EXEC NhapLoaiSP N'dây chuyền', 1040000, 20
EXEC NhapLoaiSP N'vòng tay', 1040001, 30
SELECT * FROM LOAISP

EXEC NhapSP 1030000, N'dây chuyền bạc'
EXEC NhapSP 1030001, N'vòng tay vàng'
SELECT * FROM SANPHAM




EXEC NhapNCC N'Sugar', N'ktx', '0836549765'
SELECT * FROM NHACUNGCAP

--EXEC NhapPMH 1010000
INSERT INTO PHIEUMUAHANG VALUES ('26-05-2022',1010000)
SELECT * FROM PHIEUMUAHANG
select NgayLapPMH from PHIEUMUAHANG

EXEC NhapChiTietPMH 1, 1020000, 30, 2000000
EXEC NhapChiTietPMH 1, 1020001, 14, 1000000

--EXEC NhapChiTietPMH 2, 1020001, 14, 1000000
SELECT* FROM CT_PMH

INSERT dbo.LOAIDICHVU
(
    TenLoaiDV,
    DonGiaDV
)
VALUES
(   N'Mai kim cuong', -- TenLoaiDV - nvarchar(30)
    250000 -- DonGiaDV - money
    )

INSERT dbo.LOAIDICHVU
(
    TenLoaiDV,
    DonGiaDV
)
VALUES
(   N'Thay doi kich co vong', -- TenLoaiDV - nvarchar(30)
    100000 -- DonGiaDV - money
    )
INSERT dbo.LOAIDICHVU
(
    TenLoaiDV,
    DonGiaDV
)
VALUES
(   N'Danh bong nhan', -- TenLoaiDV - nvarchar(30)
    150000 -- DonGiaDV - money
    )

INSERT dbo.KHACHHANG
(
    KhachHang,
    SDT_KhachHang
)
VALUES
(   N'Lam Quang', -- TenLoaiDV - nvarchar(30)
    '0338827702' -- DonGiaDV - money
    )

INSERT dbo.KHACHHANG
(
    KhachHang,
    SDT_KhachHang
)
VALUES
(   N'Dang Phung', -- TenLoaiDV - nvarchar(30)
    0123456789 -- DonGiaDV - money
    )

	INSERT dbo.KHACHHANG
(
    KhachHang,
    SDT_KhachHang
)
VALUES
(   N'Duy Ngoc', -- TenLoaiDV - nvarchar(30)
    0987654321 -- DonGiaDV - money
    )
SELECT * FROM KHACHHANG
SELECT * FROM PHIEUDICHVU
SELECT * FROM CT_PDV

DELETE KHACHHANG WHERE MaKH = 1060002
DELETE CT_PDV WHERE SoPDV = 3
DELETE PHIEUDICHVU where SoPDV = 3


delete from BAOCAO where Thang=6
delete from CT_BAOCAO where SoLuongBanRa=0













--EXEC Nhap_BC '26-05-2022 12:23:05'
insert into BAOCAO(Thang,Nam) values(5,2022)
SELECT * FROM BAOCAO

EXEC Nhap_CTBC 1090000, 1020001

SELECT * FROM CT_BAOCAO

EXEC NhapKH N'Duy Ngoc', '083654897'
SELECT * FROM KHACHHANG

--EXEC NhapPBH 1060000
insert into PHIEUBANHANG(NgayLapPBH,MaKH) values('27-5-2022',1060000)

EXEC NhapCT_PBH 1,1020001, 12, 297387
SELECT * FROM CT_PBH

EXEC Nhap_CTBC 1090000, 1020001
SELECT * FROM CT_BAOCAO

EXEC Nhap_LoaiDV 'mài', 20
SELECT * FROM LOAIDICHVU

EXEC Nhap_PhieuDV 1060000, 200000, 2000, 12898
EXEC Nhap_CTPDV 1,1080000, 12,12,12,12,12,12, '20-05-2022 12:12:12', N'Đã giao'