
USE master
CREATE DATABASE DeliveryService
ON 
(	
	NAME = DeliveryService,
	FILENAME = 'C:\MSSQL\delivery_945.mdf',
	SIZE = 8,
	MAXSIZE = 64,
	FILEGROWTH = 4
)
LOG ON
(
	NAME = DeliveryService_log,
	FILENAME = 'C:\MSSQL\delivery_log_945.mdf',
	SIZE = 8,
	MAXSIZE = 64,
	FILEGROWTH = 4
);
GO

USE DeliveryService
-- ���������������� ����
CREATE TYPE phoneNumber
FROM bigint
GO

CREATE TYPE email
FROM nvarchar(50)
GO

CREATE TYPE passwordHash
FROM char(128)
GO

-- ���������������� ���������
CREATE DEFAULT UserStatus
AS 1
GO

CREATE DEFAULT DeliveryDefaultStatus 
AS 0
GO

CREATE DEFAULT CurrentTime
AS convert(varchar(10), GETDATE(), 108)
GO

CREATE DEFAULT CurrentDate
AS GETDATE()
GO

-- �������

CREATE RULE email
AS @x <> '' AND @x NOT LIKE '_%@__%.__%'
GO 

CREATE RULE Cyrillic
AS @x like N'%[�-��-�]%'
GO

CREATE RULE Logins
AS @x NOT LIKE '%[^abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_]%'
GO

CREATE RULE number
AS @x BETWEEN 70000000000 AND 79999999999
GO
sp_bindrule 'number', 'phoneNumber'
GO
-- �������� ������ ���� ������

CREATE TABLE PartnerCompany (
	CompanyID int NOT NULL,
	CompanyName nvarchar(20), 
	Phone phoneNumber not null,
	LegalAddress nvarchar(65) not null
	CONSTRAINT PK_PartnerCompany PRIMARY KEY (CompanyID) 
	)
GO

CREATE TABLE Users (
	ID int not null UNIQUE,
	UserLogin nvarchar(20) not null UNIQUE,
	PasswordHash passwordHash not null,
	AccessLevel int
	CONSTRAINT PK_Users PRIMARY KEY (ID)
)
GO

sp_bindefault 'UserStatus', 'Users.AccessLevel';
GO
sp_bindrule 'Logins', 'Users.UserLogin';
GO

CREATE TABLE City (
	CityID int not null,
	CityName nvarchar(25) not null
	CONSTRAINT PK_City PRIMARY KEY (CityID)
)

CREATE TABLE Courier (
	CourierID int not null,
	FirstName nvarchar(25) not null, 
	MiddleName nvarchar(25),
	LastName nvarchar(25) not null,
	Birthday date not null,
	Phone phoneNumber not null,
	PartnerCompany int,
	City int not null,
	District nvarchar(65) not null,
	Car bit not null
	CONSTRAINT PK_Courier PRIMARY KEY (CourierID),
	CONSTRAINT FK_Courier_PartnerCompany FOREIGN KEY (PartnerCompany) 
								REFERENCES PartnerCompany(CompanyID),
	CONSTRAINT FK_Courier_Users FOREIGN KEY (CourierID) 
								REFERENCES Users(ID),
	CONSTRAINT FK_City_Courier FOREIGN KEY (City)
								REFERENCES City(CityID)
	)	
GO

sp_bindrule 'Cyrillic', 'Courier.FirstName';
GO
sp_bindrule 'Cyrillic', 'Courier.LastName';
GO


CREATE TABLE Client (
	ClientID int not null,
	FirstName nvarchar(25) not null, 
	MiddleName nvarchar(25),
	LastName nvarchar(25) not null,
	LastDelivery nvarchar(65),
	LastShipment nvarchar(65),
	Phone phoneNumber not null,
	Email email null,
	CONSTRAINT PK_Client PRIMARY KEY (ClientID),
	CONSTRAINT FK_Client_Users FOREIGN KEY (ClientID) 
								REFERENCES Users(ID)
)
GO

sp_bindrule 'Cyrillic', 'Client.FirstName';
GO

sp_bindrule 'Cyrillic', 'Client.LastName';
GO



CREATE TABLE CargoType (
	TypeID int not null,
	TypeName varchar(25) not null
	CONSTRAINT PK_CargoType PRIMARY KEY (TypeID)
)
GO

CREATE TABLE Storage (
	StorageID int not null,
	StorageName nvarchar(25) not null,
	Capacity int not null,
	City int not null,
	StorageAddress nvarchar(65) not null,
	CONSTRAINT PK_Storage PRIMARY KEY (StorageID),
	CONSTRAINT FK_City_Strorage FOREIGN KEY (City)
							REFERENCES City(CityID)
)
GO

CREATE TABLE Postamat (
	PostamatID int not null,
	City int not null,
	PostamatAddress varchar(65) not null, 
	Capacity int
	CONSTRAINT PK_Postamat PRIMARY KEY (PostamatID)
	CONSTRAINT FK_Postamat_City FOREIGN KEY (City)
								REFERENCES City(CityID)
)
GO

CREATE TABLE Tariff (
	TariffID int not null, 
	TariffName varchar(25) not null,
	Rate money not null, 
	Fragile bit not null,
	Toxic bit not null
	CONSTRAINT PK_Tariff PRIMARY KEY (TariffID)
)
GO


CREATE TABLE DeliveryStatus (
	StatusID int not null, 
	StatusName varchar(30)
	CONSTRAINT PK_DeliveryStatus PRIMARY KEY (StatusID)
)
GO

CREATE TABLE Cargo (
	CargoID int not null,
	CargoType int not null,
	CargoName nvarchar(50),
	Storage int,
	Shipper int not null, 
	ArrivalDate date not null,
	ArrivalTime time not null,
	CargoWeight real not null, 
	Height real not null,
	Width real not null,
	Depth real not null
	CONSTRAINT PK_Cargo PRIMARY KEY (CargoID)
	CONSTRAINT FK_Cargo_Type FOREIGN KEY (CargoType) 
								REFERENCES CargoType(TypeID),
	CONSTRAINT FK_Cargo_Storage FOREIGN KEY (Storage) 
								REFERENCES Storage(StorageID),
	CONSTRAINT FK_Cargo_Client FOREIGN KEY (Shipper) 
								REFERENCES Client(ClientID),
)
GO

sp_bindefault 'CurrentDate', 'Cargo.ArrivalDate'
GO

sp_bindefault 'CurrentTime', 'Cargo.ArrivalTime'
GO


CREATE TABLE Delivery (
	DeliveryID int not null, 
	Receiver int not null,
	DeliveryCity int not null,
	DeliveryAddress varchar(50),
	Postamat int null,
	DeliveryDate date null,
	DeliveryTime time null,
	DeliveryStatus int,
	Tariff int,
	Price money
	CONSTRAINT PK_Delivery PRIMARY KEY (DeliveryID)
	CONSTRAINT FK_Delivery_Client FOREIGN KEY (Receiver)
									REFERENCES Client(ClientID),
	CONSTRAINT FK_Delivery_Status FOREIGN KEY (DeliveryStatus)
									REFERENCES DeliveryStatus(StatusID),
	CONSTRAINT FK_Delivery_Tariff FOREIGN KEY (Tariff)
									REFERENCES Tariff(TariffID),
	CONSTRAINT FK_Delivery_Postamat FOREIGN KEY (Postamat)
										REFERENCES Postamat(PostamatID),
	CONSTRAINT FK_Delivery_City FOREIGN KEY (DeliveryCity)
									REFERENCES City(CityID)
)
GO

sp_bindefault 'DeliveryDefaultStatus', 'Delivery.DeliveryStatus'
GO

sp_bindefault 'CurrentDate', 'Delivery.DeliveryDate'
GO

sp_bindefault 'CurrentTime', 'Delivery.DeliveryTime'
GO


CREATE TABLE CourierDelivery (
	Courier int not null, 
	Delivery int not null,
	IssueDate date not null,
	IssueTime time not null, 

	CONSTRAINT PK_CourierDelivery PRIMARY KEY (Courier,Delivery),
	CONSTRAINT FK_Courier FOREIGN KEY (Courier) 
							REFERENCES Courier(CourierID),
	CONSTRAINT FK_Delivery FOREIGN KEY (Delivery) 
							REFERENCES Delivery(DeliveryID)
)
GO

sp_bindefault 'CurrentDate', 'CourierDelivery.IssueDate'
GO

sp_bindefault 'CurrentTime', 'CourierDelivery.IssueTime'
GO

CREATE TABLE CargoDelivery (
	Cargo int not null,
	Delivery int not null
	CONSTRAINT PK_CargoDelivery PRIMARY KEY (Cargo, Delivery),
	CONSTRAINT FK_Cargo FOREIGN KEY (Cargo)
						REFERENCES Cargo(CargoID),
	CONSTRAINT FK_Cargo_Delivery FOREIGN KEY (Delivery)
						REFERENCES Delivery(DeliveryID)
)
GO


INSERT INTO City 
VALUES (0, '������'),
		(1, '������'),
		(2, '������')

INSERT INTO Tariff 
VALUES (0, '�������', 350, 0, 0),
		(1, '�������', 450, 0, 0), 
		(2, '�������', 600, 1, 0),
		(3, '���������', 1200, 0, 1),
		(4, '��� ��������', 2000, 1, 1)
GO

INSERT INTO DeliveryStatus 
VALUES (0, '������� � ���������'), 
		(1, '� ���������'),
		(2, '� ����'), 
		(3, '�� ������'), 
		(4, '������� �������'),
		(5, '���������')
GO	

INSERT INTO Storage 
VALUES (0, '�����-1', 300, 0, '������������ �����, 15'),
		(1, '��������-1', 150, 0, '��. ��������, 16'),
		(2, '���������-1', 1300, 2,'������������� �����, 34')
GO

INSERT INTO Postamat
VALUES (0, 0, '��. ����������, 30. ������� "���������', 20),
		(1, 0, '��. ����������� �������, 35', 20)
GO

INSERT INTO CargoType
VALUES (0, '������'),
		(1, '���������'),
		(2, '�������'), 
		(3, '�������'),
		(4, '������� �������'),
		(5, '������������'), 
		(6, '���������'),
		(7, '�������')
GO

INSERT INTO PartnerCompany
VALUES (0, 'Fragile Express', '79995553333', '������, ���������� �����, 5�'),
		(1, 'Bridges', '79995553334', '������, ��. �������, 17')
GO




INSERT INTO Users 
VALUES (0, 'admin', 'APPySUTbEqrObZUVTu8EyqumPa+uKMaTq8h+DNULhcmjEOOVSeiccUY/g6TyOnhrFg==', 2),
		(1, 'user',	'AH66d90aLNEpG7xhMDo7K99XCUPadAnFMk55NxzYMSt3xb0MuAaDLc5Cxfefp21kfA==',	0),
		(2, 'user2', 'AGsbfyabfPCBn/vYe+6lfQSv4+cNXyBNvxKIW+m149I4AISZU1Ky65v4ye+4SjoDzg==', 0),
		(3, 'samporter', 'ABPweTg4oVPw44YRFPBdj95BUU+vb4/yPPV542RbSt8ziO2LqphDNuhsoar3KdN7sw==', 1)
GO

INSERT INTO Client 
	VALUES (1, '����', '��������', '������', NULL, NULL, '79999999999', 'test@delivery.ru'),
			(2, '����', '��������', '������', NULL, NULL, '79009019091', '')
GO

INSERT INTO Courier
VALUES (3, '���', '������', '�������', '1982-07-16', '79999999999', NULL, 0, '', 1)
GO 


INSERT INTO Delivery 
VALUES (0, '2', 0, NULL, NULL, NULL, NULL, 0, 0, 350)
GO

INSERT INTO Cargo 
	VALUES (0, 0, '������', 1, 1, '10-05-2022', '15:00', 100, 1, 15, 7)
GO

INSERT INTO CargoDelivery 
VALUES (0, 0)
GO

-- �������� ��� �������� � ���������� ������
CREATE PROCEDURE GetDeliveriesByCity @name varchar(25)
AS
SELECT * 
FROM Delivery JOIN City ON Delivery.DeliveryCity = City.CityID
WHERE CityName = @name

exec GetDeliveriesByCity '������'
Go


--������ �� �������� � ��������� ������� �� ��������������� ��������
CREATE TRIGGER TCityRestrict
ON City
AFTER DELETE, UPDATE
AS
BEGIN
ROLLBACK TRAN
PRINT '��������/��������� ������� �� ��������������� �������� ���������'
END
GO

DELETE FROM City WHERE City.CityID = 1
GO

CREATE TRIGGER TStorageRestrict
ON Storage
AFTER DELETE, UPDATE
AS
BEGIN
ROLLBACK TRAN
PRINT '��������/��������� ������� �� ��������������� �������� ���������'
END
GO

CREATE TRIGGER TPostamatRestrict
ON Postamat
AFTER DELETE, UPDATE
AS
BEGIN
ROLLBACK TRAN
PRINT '��������/��������� ������� �� ��������������� �������� ���������'
END
GO

CREATE TRIGGER TTariffRestrict
ON Tariff
AFTER DELETE, UPDATE
AS
BEGIN
ROLLBACK TRAN
PRINT '��������/��������� ������� �� ��������������� �������� ���������'
END
GO

CREATE TRIGGER TCargoTypeRestrict
ON CargoType
AFTER DELETE, UPDATE
AS
BEGIN
ROLLBACK TRAN
PRINT '��������/��������� ������� �� ��������������� �������� ���������'
END
GO

CREATE TRIGGER TStatusRestrict
ON DeliveryStatus
AFTER DELETE, UPDATE
AS
BEGIN
ROLLBACK TRAN
PRINT '��������/��������� ������� �� ��������������� �������� ���������'
END
GO

select * from Courier



