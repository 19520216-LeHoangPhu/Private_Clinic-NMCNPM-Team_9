﻿CREATE DATABASE QUANLYPHONGMACHTU
USE QUANLYPHONGMACHTU

CREATE TABLE BENHNHAN
(
	MABENHNHAN NVARCHAR(7) PRIMARY KEY, 
	HOTEN NVARCHAR(50) NOT NULL, 
	GIOITINH NVARCHAR(4) CHECK ((GIOITINH = 'Nam' OR GIOITINH = 'Nữ' OR GIOITINH = 'Khác') 
		AND GIOITINH IS NOT NULL), 
	NGAYSINH SMALLDATETIME CHECK (NGAYSINH <= GETDATE() AND NGAYSINH IS NOT NULL), 
	DIACHI NVARCHAR(100) NOT NULL
)

CREATE TABLE CTKB
(
	MACTKB NVARCHAR(9) PRIMARY KEY, 
	MABENHNHAN NVARCHAR(7) NOT NULL, 
	NGAYKHAMBENH SMALLDATETIME CHECK (NGAYKHAMBENH >= GETDATE() AND NGAYKHAMBENH IS NOT NULL), 
	CONSTRAINT PRIMARYKEYCTKB UNIQUE (MABENHNHAN, NGAYKHAMBENH), 
	CONSTRAINT FKBENHNHAN FOREIGN KEY (MABENHNHAN) REFERENCES BENHNHAN (MABENHNHAN)
)

CREATE TABLE THAMSO
(
	TENTHAMSO NVARCHAR(20) PRIMARY KEY, 
	GIATRI INT CHECK (GIATRI > 0 AND GIATRI IS NOT NULL)
)

CREATE TABLE DONVITINH
(
	MADONVITINH NVARCHAR(5) PRIMARY KEY, 
	TENDONVITINH NVARCHAR(20) NOT NULL, 
	CONSTRAINT PRIMARYKEYDONVITINH UNIQUE (TENDONVITINH)
)

CREATE TABLE THUOC
(
	MATHUOC NVARCHAR(6) PRIMARY KEY, 
	TENTHUOC NVARCHAR(50) NOT NULL, 
	SOLUONGTON INT CHECK (SOLUONGTON >= 0 AND SOLUONGTON IS NOT NULL), 
	DONGIANHAP INT CHECK (DONGIANHAP >= 0 AND DONGIANHAP IS NOT NULL), 
	DONGIABAN INT, 
	MADONVITINH NVARCHAR(5) NOT NULL, 
	TYLETINHDONGIABAN INT CHECK (TYLETINHDONGIABAN >= 100 AND TYLETINHDONGIABAN IS NOT NULL), 
	CONSTRAINT PRIMARYKEY UNIQUE (MATHUOC, MADONVITINH), 
	CONSTRAINT SOLUONGTON DEFAULT 0 FOR [SOLUONGTON], 
	CONSTRAINT FKDONVITINH FOREIGN KEY (MADONVITINH) REFERENCES DONVITINH (MADONVITINH)
)

CREATE TABLE CTPHIEUNT
(
	MACTPHIEUNT NVARCHAR(10) PRIMARY KEY, 
	MATHUOC NVARCHAR(6) NOT NULL, 
	SOLUONGNHAP INT CHECK (SOLUONGNHAP > 0 AND SOLUONGNHAP IS NOT NULL), 
	NGAYNHAPTHUOC SMALLDATETIME CHECK (NGAYNHAPTHUOC >= GETDATE() AND NGAYNHAPTHUOC IS NOT NULL), 
	DONGIABANHIENTAI INT, 
	TYLETINHDONGIABANHIENTAI INT, 
	CONSTRAINT FKTHUOCCTPHIEUNT FOREIGN KEY (MATHUOC) REFERENCES THUOC (MATHUOC)
)

CREATE TABLE BENH
(
	MABENH NVARCHAR(3) PRIMARY KEY, 
	TENBENH NVARCHAR(50) UNIQUE, 
	CONSTRAINT CHECKTENBENH CHECK (TENBENH IS NOT NULL)
)

CREATE TABLE PHIEUKB
(
	MAPHIEUKB NVARCHAR(8) PRIMARY KEY, 
	MACTKB NVARCHAR(9) NOT NULL, 
	TRIEUCHUNG NVARCHAR(50) NOT NULL, 
	MABENH NVARCHAR(3) NOT NULL, 
	CONSTRAINT FKCTKB FOREIGN KEY (MACTKB) REFERENCES CTKB (MACTKB), 
	CONSTRAINT FKBENH FOREIGN KEY (MABENH) REFERENCES BENH (MABENH)
)

CREATE TABLE CACHDUNG
(
	MACACHDUNG NVARCHAR(4) PRIMARY KEY, 
	TENCACHDUNG NVARCHAR(20) NOT NULL, 
	CONSTRAINT PRIMARYKEYCACHDUNG UNIQUE (TENCACHDUNG)
)

CREATE TABLE CTPHIEUKB
(
	MACTPHIEUKB NVARCHAR(10) PRIMARY KEY, 
	MAPHIEUKB NVARCHAR(8) NOT NULL, 
	MATHUOC NVARCHAR(6) NOT NULL, 
	SOLUONG INT CHECK (SOLUONG > 0 AND SOLUONG IS  NOT NULL), 
	MACACHDUNG NVARCHAR(4) NOT NULL, 
	TIENTHUOC INT, 
	CONSTRAINT PRIMARYKEYCTPHIEUKB UNIQUE (MAPHIEUKB, MATHUOC), 
	CONSTRAINT FKPHIEUKB FOREIGN KEY (MAPHIEUKB) REFERENCES PHIEUKB (MAPHIEUKB), 
	CONSTRAINT FKTHUOCCTPHIEUKB FOREIGN KEY (MATHUOC) REFERENCES THUOC (MATHUOC), 
	CONSTRAINT FKCACHDUNG FOREIGN KEY (MACACHDUNG) REFERENCES CACHDUNG (MACACHDUNG)
)

CREATE TABLE HOADON
(
	SOHD NVARCHAR(7) PRIMARY KEY, 
	MACTKB NVARCHAR(9) NOT NULL, 
	TIENKHAM INT, 
	TONGTIENTHUOC INT, 
	CONSTRAINT FKCTKBA FOREIGN KEY (MACTKB) REFERENCES CTKB (MACTKB)
)

CREATE TABLE DOANHTHU
(
	MADOANHTHU NVARCHAR(7) PRIMARY KEY, 
	NGAYLAP SMALLDATETIME CHECK ((YEAR(NGAYLAP) < YEAR(GETDATE()) OR (YEAR(NGAYLAP) = YEAR(GETDATE()) 
		AND (MONTH(NGAYLAP) < MONTH(GETDATE())))) AND NGAYLAP IS NOT NULL), 
	SOBENHNHAN INT, 
	DOANHTHU INT, 
	TYLE INT, 
	CONSTRAINT PRIMARYKEYDOANHTHU UNIQUE (NGAYLAP)
)

CREATE TABLE SUDUNGTHUOC
(
	MASUDUNGTHUOC NVARCHAR(8) PRIMARY KEY, 
	THANG INT CHECK (THANG >= 1 AND THANG <= 12 AND THANG IS NOT NULL), 
	NAM INT NOT NULL, 
	MATHUOC NVARCHAR(6) NOT NULL, 
	SOLUONGDUNG INT, 
	SOLANDUNG INT, 
	CONSTRAINT PRIMARYKEYSUDUNGTHUOC UNIQUE (THANG, NAM, MATHUOC), 
	CONSTRAINT THANGNAM CHECK (NAM < YEAR(GETDATE()) OR (NAM = YEAR(GETDATE()) AND 
		THANG < MONTH(GETDATE()))), 
	CONSTRAINT FKTHUOCSUDUNGTHUOC FOREIGN KEY (MATHUOC) REFERENCES THUOC (MATHUOC)
)

CREATE TRIGGER TINHDONGIABAN ON THUOC
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE THUOC
		SET DONGIABAN = DONGIANHAP * TYLETINHDONGIABAN / 100
	END

CREATE TRIGGER TINHTIENTHUOC ON CTPHIEUKB
FOR INSERT
AS
    BEGIN
		UPDATE CTPHIEUKB
		SET TIENTHUOC = SOLUONG * (
								      SELECT DONGIABAN
									  FROM THUOC
									  WHERE CTPHIEUKB.MATHUOC = THUOC.MATHUOC
								  )
	END

CREATE TRIGGER TINHTIENKHAM ON HOADON
FOR INSERT
AS
	BEGIN
		UPDATE HOADON
		SET TIENKHAM = (
						   SELECT GIATRI
						   FROM THAMSO
						   WHERE TENTHAMSO = 'Tiền khám'
					   )
	END

CREATE TRIGGER TINHTONGTIENTHUOC ON HOADON
FOR INSERT
AS
	BEGIN
		UPDATE HOADON
		SET TONGTIENTHUOC = (
								SELECT SUM(TIENTHUOC)
								FROM CTPHIEUKB CTP, PHIEUKB P, CTKB CT
								WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND P.MACTKB = CT.MACTKB 
									AND HOADON.MACTKB = CT.MACTKB
							)
	END

CREATE TRIGGER DIEUCHINHCTPHIEUKB ON CTPHIEUKB
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE HOADON
		SET TONGTIENTHUOC = (
								SELECT SUM(TIENTHUOC)
								FROM CTPHIEUKB CTP, PHIEUKB P, CTKB CT
								WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND P.MACTKB = CT.MACTKB 
									AND HOADON.MACTKB = CT.MACTKB
							)
		WHERE MACTKB = (
								SELECT CT.MACTKB
								FROM INSERTED I, PHIEUKB P, CTKB CT
								WHERE I.MAPHIEUKB = P.MAPHIEUKB AND P.MACTKB = CT.MACTKB
								UNION
								SELECT CT.MACTKB
								FROM DELETED D, PHIEUKB P, CTKB CT
								WHERE D.MAPHIEUKB = P.MAPHIEUKB AND P.MACTKB = CT.MACTKB
							)
	END

CREATE TRIGGER DEMSOBENHNHAN ON DOANHTHU
FOR INSERT
AS
	BEGIN
		UPDATE DOANHTHU
		SET SOBENHNHAN = (
							 SELECT COUNT(*)
							 FROM BENHNHAN BN, CTKB CT
							 WHERE NGAYLAP = NGAYKHAMBENH AND BN.MABENHNHAN = CT.MABENHNHAN
						 )
	END

CREATE TRIGGER THEMBENHNHAN ON BENHNHAN
FOR INSERT
AS
	BEGIN
		UPDATE DOANHTHU
		SET SOBENHNHAN = (
							 SELECT COUNT(*)
							 FROM BENHNHAN BN, CTKB CT
							 WHERE NGAYLAP = NGAYKHAMBENH AND BN.MABENHNHAN = CT.MABENHNHAN
						 )
		WHERE NGAYLAP = (
							SELECT NGAYKHAMBENH
							FROM INSERTED I, CTKB CT
							WHERE I.MABENHNHAN = CT.MABENHNHAN
						)
	END

CREATE TRIGGER TINHDOANHTHU ON DOANHTHU
FOR INSERT
AS
	BEGIN
		UPDATE DOANHTHU
		SET DOANHTHU = (
						   SELECT SUM(TONGTIENTHUOC)
						   FROM HOADON HD, CTKB CT
						   WHERE HD.MACTKB = CT.MACTKB AND CT.NGAYKHAMBENH = DOANHTHU.NGAYLAP
					   )
	END

CREATE TRIGGER DIEUCHINHHOADON ON HOADON
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE DOANHTHU
		SET DOANHTHU = (
						   SELECT SUM(TONGTIENTHUOC)
						   FROM HOADON HD, CTKB CT
						   WHERE HD.MACTKB = CT.MACTKB AND CT.NGAYKHAMBENH = DOANHTHU.NGAYLAP
					   )
		WHERE NGAYLAP = (
							SELECT CT.NGAYKHAMBENH
							FROM INSERTED I, CTKB CT
							WHERE I.MACTKB = CT.MACTKB
							UNION
							SELECT CT.NGAYKHAMBENH
							FROM DELETED D, CTKB CT
							WHERE D.MACTKB = CT.MACTKB
						)
	END

CREATE TRIGGER TINHTYLEDOANHTHU ON DOANHTHU
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE DOANHTHU
		SET TYLE = DOANHTHU * 100 / (
										SELECT SUM(DT.DOANHTHU)
										FROM DOANHTHU DT
										WHERE MONTH(DT.NGAYLAP) = MONTH(DOANHTHU.NGAYLAP)
									)
	END

CREATE TRIGGER TINHSOLUONGTHUOCSUDUNG ON SUDUNGTHUOC
FOR INSERT
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLUONGDUNG = (
								SELECT SUM(SOLUONG)
								FROM CTPHIEUKB CTP, PHIEUKB P, CTKB CT
								WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND P.MACTKB = CT.MACTKB 
									AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
									AND SUDUNGTHUOC.THANG = MONTH(CT.NGAYKHAMBENH) 
									AND SUDUNGTHUOC.NAM = YEAR(CT.NGAYKHAMBENH) 
						  )
	END

CREATE TRIGGER DIEUCHINHCTPHIEUKBA ON CTPHIEUKB
FOR INSERT
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLUONGDUNG = (
							    SELECT SUM(SOLUONG)
								FROM CTPHIEUKB CTP, PHIEUKB P, CTKB CT
								WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND P.MACTKB = CT.MACTKB 
									AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
									AND SUDUNGTHUOC.THANG = MONTH(CT.NGAYKHAMBENH) 
									AND SUDUNGTHUOC.NAM = YEAR(CT.NGAYKHAMBENH) 
						  )
		WHERE MATHUOC = (
							SELECT MATHUOC
							FROM INSERTED
						)
	END

CREATE TRIGGER DEMSOLANDUNG ON SUDUNGTHUOC
FOR INSERT
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLANDUNG = (
							SELECT COUNT(*)
							FROM CTPHIEUKB CTP, PHIEUKB P, CTKB CT
							WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND P.MACTKB = CT.MACTKB
								AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
								AND SUDUNGTHUOC.THANG = MONTH(CT.NGAYKHAMBENH) 
								AND SUDUNGTHUOC.NAM = YEAR(CT.NGAYKHAMBENH)
						)
	END

CREATE TRIGGER DIEUCHINHCTPHIEUKBB ON CTPHIEUKB
FOR INSERT
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLANDUNG = (
							SELECT COUNT(*)
							FROM CTPHIEUKB CTP, PHIEUKB P, CTKB CT
							WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND P.MACTKB = CT.MACTKB 
								AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
								AND SUDUNGTHUOC.THANG = MONTH(CT.NGAYKHAMBENH) 
								AND SUDUNGTHUOC.NAM = YEAR(CT.NGAYKHAMBENH)
						)
		WHERE MATHUOC = (
							SELECT MATHUOC
							FROM INSERTED
						)
	END
	
CREATE TRIGGER NHAPTHUOC ON CTPHIEUNT
FOR INSERT
AS
	BEGIN
		UPDATE THUOC
		SET SOLUONGTON += (
							  SELECT I.SOLUONGNHAP
							  FROM INSERTED I
						  )
		WHERE MATHUOC = (
							SELECT I.MATHUOC
							FROM INSERTED I
						)
	END
	
CREATE TRIGGER SUDUNGTHUOCA ON CTPHIEUKB
FOR INSERT
AS
	BEGIN
		UPDATE THUOC
		SET SOLUONGTON -= (
							  SELECT I.SOLUONG
							  FROM INSERTED I
						  )
		WHERE MATHUOC = (
							SELECT I.MATHUOC
							FROM INSERTED I
						)
	END
	
CREATE TRIGGER TINHDONGIABANHIENTAI ON CTPHIEUNT
FOR INSERT
AS
	BEGIN
		UPDATE CTPHIEUNT
		SET DONGIABANHIENTAI = (
								   SELECT T.DONGIABAN
								   FROM THUOC T
								   WHERE T.MATHUOC = CTPHIEUNT.MATHUOC
							   )
	END

CREATE TRIGGER TINHTYLEDONGIABANHIENTAI ON CTPHIEUNT
FOR INSERT
AS
	BEGIN
		UPDATE CTPHIEUNT
		SET TYLETINHDONGIABANHIENTAI = (
								   SELECT T.TYLETINHDONGIABAN
								   FROM THUOC T
								   WHERE T.MATHUOC = CTPHIEUNT.MATHUOC
							   )
	END