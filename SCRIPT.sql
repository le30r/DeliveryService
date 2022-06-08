
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

CREATE RULE RealValues 
AS @x > 0
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

sp_bindrule 'RealValues', 'Cargo.CargoWeight'
GO

sp_bindrule 'RealValues', 'Cargo.Height'
GO

sp_bindrule 'RealValues', 'Cargo.Width'
GO

sp_bindrule 'RealValues', 'Cargo.Depth'
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


GO

-- ���������� ������������
CREATE PROC AddUser (@login nvarchar(20), @password varchar(20), @level int) 
AS
DECLARE @id int
SELECT @id = MAX(ID) + 1
FROM Users
DECLARE @authdata nvarchar(40)
SET @authdata = @login + @password
INSERT INTO Users
VALUES (@id, @login, HASHBYTES('SHA2_256', @authdata), @level) 
RETURN @id
GO

--�������� �����������
CREATE PROC CheckAuthData (@login nvarchar(20), @password varchar(20))
AS
DECLARE @authdata nvarchar(40)
SET @authdata = @login + @password
IF HASHBYTES('SHA2_256', @authdata) = (SELECT PasswordHash
										FROM Users
										WHERE @login = UserLogin)
return (SELECT ID FROM Users WHERE @login = UserLogin)
ELSE 
return -1
GO

-- ���������� �������
CREATE PROC AddCourier (@login nvarchar(20), @password varchar(20),
						@FirstName nvarchar(25), @MiddleName nvarchar(25), @LastName nvarchar(25), 
						@birthday date, @phone phoneNumber, @city int, @district nvarchar(65), @car bit)
AS
DECLARE @ID int
EXEC @ID = AddUser @login, @password, 1
INSERT INTO Courier
VALUES (@ID, @FirstName, @MiddleName, @LastName, @birthday, @phone, NULL, @city, @district, @car)
RETURN @ID
GO

--�������� �������
CREATE PROC RemoveCourier (@login nvarchar(20))
AS
DECLARE @id int
SELECT @id = ID
FROM Users
WHERE @login = UserLogin
IF NOT EXISTS (SELECT * FROM CourierDelivery WHERE Courier = @id) 
	BEGIN
	DELETE FROM Courier
	WHERE CourierID = @id

	DELETE FROM Users 
	WHERE ID = @id
	END
ELSE
PRINT '���������� ������� �������, �������� ��������'
IF @@ROWCOUNT = 0 PRINT '������ � ������ ������� �� ������!'
GO

--���������� �������
CREATE PROC AddClient (@login nvarchar(20), @password varchar(20),
						@FirstName nvarchar(25), @MiddleName nvarchar(25), @LastName nvarchar(25), 
						 @phone phoneNumber, @email email)
AS
DECLARE @ID int
EXEC @ID = AddUser @login, @password, 0
INSERT INTO Client
VALUES (@ID, @FirstName, @MiddleName, @LastName, NULL, NULL, @phone, @email)
RETURN @ID
GO

--�������� �������
CREATE PROC RemoveClient (@login nvarchar(20))
AS
DECLARE @id int
SELECT @id = ID
FROM Users
WHERE @login = UserLogin
IF NOT EXISTS (SELECT * FROM Delivery WHERE Receiver = @id)
	BEGIN
	DELETE FROM Client
	WHERE ClientID = @id
	DELETE FROM Users 
	WHERE ID = @id
	END
ELSE
	PRINT '���������� ������� �������, �������� ��������'
IF @@ROWCOUNT = 0 PRINT '������ � ������ ������� �� ������!'
GO


--���������� �����
CREATE PROC AddCargo (@CargoType int, @CargoName nvarchar(50), @Storage int, @Shipper int, @CargoWeight real, @H real, @W real, @D real)
AS
DECLARE @id int
SELECT @id = MAX (CargoID) +1
FROM Cargo
INSERT INTO Cargo
VALUES (@id, @CargoType, @CargoName, @Storage, @Shipper, GETDATE(), CURRENT_TIMESTAMP, @CargoWeight, @H, @W, @D)
GO

CREATE PROCEDURE GetDeliveriesByCity @name varchar(25)
AS
SELECT * 
FROM Delivery JOIN City ON Delivery.DeliveryCity = City.CityID
WHERE CityName = @name
GO

exec GetDeliveriesByCity '������'
Go


--������� ����������� ���������� � �������� ������, �� ��������������� ������
CREATE TRIGGER TCargoTypes
ON CargoDelivery
AFTER INSERT, UPDATE
AS
DECLARE cursor_deliveries CURSOR FOR SELECT DISTINCT Delivery FROM inserted
OPEN cursor_deliveries
DECLARE @delivery_id int
FETCH NEXT FROM cursor_deliveries INTO @delivery_id
WHILE @@FETCH_STATUS = 0
	BEGIN
	DECLARE @tariff int
	SELECT @tariff = Tariff
	FROM Delivery
	WHERE DeliveryID = @delivery_id
	IF EXISTS (SELECT * FROM Tariff WHERE TariffID = @tariff AND Toxic != 1)
		DELETE FROM CargoDelivery 
		WHERE Delivery = @delivery_id AND Cargo IN (SELECT CargoID
						FROM Cargo
						WHERE CargoType = 6)
	IF @@ROWCOUNT != 0 PRINT '��� ������ �� ������������� ������ ��������'
	IF EXISTS (SELECT * FROM Tariff WHERE TariffID = @tariff AND Fragile != 1)
		DELETE FROM CargoDelivery 
		WHERE Delivery = @delivery_id AND Cargo IN (SELECT CargoID
												FROM Cargo
												WHERE CargoType = 7)
	IF @@ROWCOUNT != 0 PRINT '��� ������ �� ������������� ������ ��������'
	FETCH NEXT FROM cursor_deliveries INTO @delivery_id
	END
CLOSE cursor_deliveries
DEALLOCATE cursor_deliveries
GO

--�������, ����������� ���������� ������ ��� ������ ������� ������ ������ 15 ��
ALTER TRIGGER TCargoWeight
ON CargoDelivery
AFTER INSERT, UPDATE
AS
DECLARE cursor_deliveries CURSOR FOR SELECT DISTINCT Delivery FROM inserted
OPEN cursor_deliveries
DECLARE @delivery_id int
FETCH NEXT FROM cursor_deliveries INTO @delivery_id
WHILE @@FETCH_STATUS = 0
	BEGIN
	DECLARE @DeliveryWeight real
	SET @DeliveryWeight  = 0
	DECLARE @courier_id int, @cargo_id int
	SELECT @courier_id = Courier FROM CourierDelivery WHERE Delivery = @delivery_id
		IF EXISTS (SELECT * FROM Courier WHERE CourierID = @courier_id AND Car = 0)
			BEGIN
			DECLARE cursor_cargo CURSOR LOCAL FOR SELECT Cargo FROM inserted WHERE Delivery = @delivery_id 
			OPEN cursor_cargo
			FETCH FROM cursor_cargo INTO @cargo_id 
			WHILE @@FETCH_STATUS = 0
				BEGIN
					SET @DeliveryWeight += (SELECT CargoWeight
											FROM Cargo
											WHERE CargoID = @cargo_id)
					IF (@DeliveryWeight > 15000) 
						BEGIN
						DELETE FROM CargoDelivery
						WHERE Cargo = @cargo_id AND Delivery = @delivery_id
						SET @DeliveryWeight -= (SELECT CargoWeight
											FROM Cargo
											WHERE CargoID = @cargo_id)
						PRINT '����� �������� ������ 15 �� ��������� ��� ������ �������'
						END
				FETCH FROM cursor_cargo INTO @cargo_id
				END
			CLOSE cursor_cargo
			DEALLOCATE cursor_cargo
			FETCH NEXT FROM cursor_deliveries INTO @delivery_id
			END
	END	
CLOSE cursor_deliveries
DEALLOCATE cursor_deliveries
GO




INSERT INTO CargoDelivery 
VALUES (13, 1)
DELETE FROM CargoDelivery
WHERE Cargo = 13

select * from Tariff

SELECT * FROM Cargo

select * from CourierDelivery
SELECT * FROM Client

exec AddCargo 0, '��� ����', NULL, 1, 16000, 15, 15, 15 


select * from Delivery

update Courier 
SET Car = 0
WHERE CourierID = 9
INSERT INTO CourierDelivery
VALUES (9, 1, GETDATE(), CURRENT_TIMESTAMP)

SELECT * FROM CargoDelivery
SELECT * FROM Delivery

