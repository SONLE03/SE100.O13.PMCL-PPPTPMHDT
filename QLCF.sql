DROP DATABASE CF;

CREATE DATABASE CF

USE CF
go

go
CREATE TABLE GROUPUSER
(
	id int IDENTITY(1,1) primary key,
	GroupUserID AS CAST('GUS' + right('000' + CAST(id as varchar(5)), 3) AS CHAR(6)) persisted ,
	GroupUserName nvarchar(max) NOT NULL,
	Status nvarchar(max) NOT NULL,
)

go
CREATE TABLE SERVICE
(
    id int  primary key IDENTITY(1,1),
	ServiceID AS CAST('SV' + right('000' + CAST(id as varchar(3)), 3) as char(5))persisted,
    ServiceName NVARCHAR(MAX) NOT NULL,
    ScreenName NVARCHAR(MAX) NOT NULL
)

go
CREATE TABLE PERMISSION
(
   	GroupUserID INT FOREIGN KEY REFERENCES GROUPUSER on delete cascade,
    ServiceID INT FOREIGN KEY REFERENCES SERVICE on delete cascade,
    PRIMARY KEY (GroupUserID, ServiceID)
)

go
CREATE TABLE _USER
(
	id INT IDENTITY PRIMARY KEY,
	UserID  AS CAST('US'+ RIGHT('000000' + CAST(id AS VARCHAR(4)), 4) AS CHAR(6)) PERSISTED,
    UserFullName NVARCHAR(MAX) NOT NULL,
    DateOfBirth date,
	Phone NVARCHAR(MAX),
	Address NVARCHAR(MAX),
	Email VARCHAR(MAX),
   	UserName VARCHAR(256) UNIQUE NOT NULL,
    Password VARCHAR(MAX) NOT NULL,
	Image VARCHAR(MAX),
	Status nvarchar(max) NOT NULL,
	GroupUserID INT REFERENCES GROUPUSER on delete cascade NOT NULL
)
go
CREATE TABLE CATEGORY
(
	id int IDENTITY(1,1)  primary key,
	CategoryID As Cast('CT' + right('0000' + CAST(id as varchar(4)), 4) as char(6)) persisted,  
	CategoryName NVARCHAR(MAX) NOT NULL,
	Status nvarchar(max) NOT NULL,
)
go
CREATE TABLE EVENT(
	id INT IDENTITY PRIMARY KEY,
	EventID As Cast('EV' + right('0000' + CAST(id as varchar(4)), 4) as char(6)) persisted, 
	EventName NVARCHAR(Max) not null,
	EventType Bit not null,
	Unit NVARCHAR(MAX),
	Discount Float DEFAULT 0.0,
	StartDate date,
	DueDate date,
	UserID int references _USER  on delete cascade,
	Status nvarchar(max) NOT NULL,
)

go
CREATE TABLE DRINKS(
	id INT IDENTITY PRIMARY KEY,
	DrinksID As Cast('DK' + right('0000' + CAST(id as varchar(4)), 4) as char(6)) persisted, 
	DrinksName NVARCHAR(MAX) NOT NULL,
	CategoryID INT references CATEGORY NOT NULL, 
	Description NVARCHAR(MAX),
	Image NVARCHAR(MAX) NOT NULL,
	Status nvarchar(max) NOT NULL,
)
go 
CREATE TABLE DRINK_EVENT(
	DrinksID INT FOREIGN KEY REFERENCES DRINKS on delete cascade,
	EventID INT FOREIGN KEY REFERENCES EVENT on delete cascade,
	primary key(DrinksID,EventID)
)

go 
CREATE TABLE _SIZE(
	id INT IDENTITY PRIMARY KEY, 
	SizeID As Cast('SZ' + right('0000' + CAST(id as varchar(4)), 4) as char(6)) persisted, 
	SizeName NVARCHAR(MAX) NOT NULL,
)
go 
CREATE TABLE DRINKS_SIZE(
	DrinksID INT FOREIGN KEY REFERENCES DRINKS on delete cascade,
    SizeID INT FOREIGN KEY REFERENCES _SIZE on delete cascade,
	OriginalPrice Float NOT NULL,
	Discount Float Default 0.0,
    PRIMARY KEY (DrinksID, SizeID)
)

GO
CREATE TABLE AREA(
	id INT IDENTITY PRIMARY KEY,
	AreaID As Cast('AR' + right('0000' + CAST(id as varchar(4)), 4) as char(6)) persisted, 
	AreaName nvarchar(MAX) NULL,
	Capacity int not null,
	Status nvarchar(max) NOT NULL,
)

GO
CREATE TABLE _TABLE(
	id INT IDENTITY PRIMARY KEY,
	TableID As Cast('TB' + right('0000' + CAST(id as varchar(4)), 4) as char(6)) persisted, 
	TableName nvarchar(MAX) NULL,
	AreaID INT references AREA NOT NULL,
	Status nvarchar(max) NOT NULL,
)


go
CREATE TABLE BILL(
	id INT IDENTITY PRIMARY KEY,
	BillID As Cast('OD' + right('0000' + CAST(id as varchar(4)), 4) as char(6)) persisted,
	BillDate DateTime NOT NULL,
	UserID int references _USER  on delete cascade,
	TableID int references _TABLE  on delete cascade,
	Status nvarchar(max) NOT NULL,
	Note NVARCHAR(MAX),
	SubTotal Float DEFAULT 0.0, 
	Tax Float DEFAULT 0.0,
	Total Float DEFAULT 0.0,
)
go
CREATE TABLE BILL_DETAIL(
	BillID int references BILL  on delete cascade,
	DrinksID int references DRINKS  on delete cascade,
	SizeID int references _SIZE  on delete cascade,
	Quantity int DEFAULT 0,
	Rate Float NOT NULL,
	Amount Float DEFAULT 0.0,
	primary key (BillID, DrinksID, SizeID)
)
go 
CREATE TABLE SUPPLIER(
	id INT IDENTITY PRIMARY KEY,
	SupplierID As Cast('SP' + right('0000' + CAST(id as varchar(4)), 4) as char(6)) persisted, 
	SupplierName NVARCHAR(MAX) NOT NULL,
	Address NVARCHAR(Max),
	Phone NVARCHAR(max),
	Status nvarchar(max) NOT NULL,
)
go
CREATE TABLE IMPORT_BILL(
	id INT IDENTITY PRIMARY KEY,
	ImportID As Cast('IB' + right('0000' + CAST(id as varchar(4)), 4) as char(6)) persisted,
	ImportName NVARCHAR(Max) not null,
	ImportDate DateTime NOT NULL,
	SupplierID INT REFERENCES SUPPLIER on delete cascade,
	UserID int references _USER  on delete cascade,
	Total Float DEFAULT 0.0,
)
go
CREATE TABLE IMPORT_BILL_DETAIL(
	No int not null,
	ImportID int references IMPORT_BILL on delete cascade,
	ImportMName NVARCHAR(MAX) NOT NULL,
	Unit NVARCHAR(MAX) not null,
	Quantity int not null,
	Rate float not null,
	Amount float not null,
	primary key(No, ImportID)
)

go
CREATE TABLE _RULE(
	id int identity(1,1) primary key,
	MinimumAge int NOT NULL,
	MaximumAge int NOT NULL,
	Tax int NOT NULL,
	MaximumDateForEvent int NOT NULL,
	MaximumPercentDiscount int NOT NULL,
)

-- INSERT DATA
go
insert into GROUPUSER(GroupUserName, Status) values ('Admin', 'Active')
insert into GROUPUSER(GroupUserName, Status) values ('Cashier', 'Active')

go

insert into SERVICE (ServiceName, ScreenName) VALUES ('Home', N'Trang Chủ')
insert into SERVICE (ServiceName, ScreenName) VALUES ('Product', N'Quản lý Sản Phẩm')
insert into SERVICE (ServiceName, ScreenName) VALUES ('Table', N'Quản lý Bàn')
insert into SERVICE (ServiceName, ScreenName) VALUES ('Order', N'Thêm Hóa Đơn')
insert into SERVICE (ServiceName, ScreenName) VALUES ('Event', N'Sự Kiện')
insert into SERVICE (ServiceName, ScreenName) VALUES ('Import', N'Quản Lý Phiếu Nhập Hàng')
insert into SERVICE (ServiceName, ScreenName) VALUES ('Employee', N'Quản Lý Người Dùng')
insert into SERVICE (ServiceName, ScreenName) VALUES ('Report', N'Quản Lý Báo Cáo')
insert into SERVICE (ServiceName, ScreenName) VALUES ('Rule', N'Thay Đổi Quy Định')
insert into SERVICE (ServiceName, ScreenName) VALUES ('Setting', N'Cài Đặt')

go
INSERT INTO PERMISSION VALUES (1, 1)
INSERT INTO PERMISSION VALUES (1, 2)
INSERT INTO PERMISSION VALUES (1, 3)
INSERT INTO PERMISSION VALUES (1, 4)
INSERT INTO PERMISSION VALUES (1, 5)
INSERT INTO PERMISSION VALUES (1, 6)
INSERT INTO PERMISSION VALUES (1, 7)
INSERT INTO PERMISSION VALUES (1, 8)
INSERT INTO PERMISSION VALUES (1, 9)
INSERT INTO PERMISSION VALUES (1, 10)

INSERT INTO PERMISSION VALUES (2, 3)
INSERT INTO PERMISSION VALUES (2, 4)
INSERT INTO PERMISSION VALUES (2, 10)

go

set dateformat dmy
go
INSERT INTO _USER(UserFullName, UserName, Password, GroupUserID, Status) 
VALUES (N'Admin Hệ Thống', 'admin123', '123', 1, 'Active')
INSERT INTO _USER(UserFullName, UserName, Password, GroupUserID, Status) 
VALUES (N'Nhân Viên Thu Ngân', 'em123', '123', 2, 'Active')

select * from GROUPUSER
select  * from _USER
select * from PERMISSION
select * from DRINK_EVENT

INSERT INTO CATEGORY (CategoryName, Status) VALUES
  ('Coffee', 'Active'),
  ('Tea', 'Active'),
  ('Smoothie', 'Active');

  INSERT INTO DRINKS (DrinksName, CategoryID, Description, Image, Status)
VALUES
  ('Cappuccino', 1, 'Espresso coffee with steamed milk foam', 'cappuccino.jpg', 'Active'),
  ('Green Tea', 2, 'Healthy green tea', 'green_tea.jpg', 'Active'),
  ('Mango Smoothie', 3, 'Blended mango goodness', 'mango_smoothie.jpg', 'Active');
  ('Latte', 1, 'Espresso coffee with steamed milk', 'latte.jpg', 'Active'),
  ('Black Tea', 2, 'Classic black tea', 'black_tea.jpg', 'Active'),
  ('Strawberry Smoothie', 3, 'Blended strawberry delight', 'strawberry_smoothie.jpg', 'Active');
  
  INSERT INTO _TABLE (TableName, AreaID, Status)
VALUES
    ('Table 1', 1, 'Active');
INSERT INTO _SIZE (SizeName) VALUES
  ('S'),
  ('M'),
  ('L');

INSERT INTO DRINKS_SIZE (DrinksID, SizeID, OriginalPrice)
VALUES
  (1, 1, 30000), -- Cappuccino, Small, OriginalPrice: $3.99, Discount: 20%
  (1, 2, 40000), -- Cappuccino, Medium, OriginalPrice: $4.99, Discount: 10%
  (1, 3, 50000), -- Cappuccino, Large, OriginalPrice: $5.99, No Discount
  (2, 1, 30000), -- Green Tea, Small, OriginalPrice: $2.49, No Discount
  (2, 2, 40000), -- Green Tea, Medium, OriginalPrice: $3.49, Discount: 15%
  (2, 3, 50000), -- Green Tea, Large, OriginalPrice: $4.49, No Discount
  (3, 1, 30000), -- Mango Smoothie, Small, OriginalPrice: $5.99, No Discount
  (3, 2, 40000), -- Mango Smoothie, Medium, OriginalPrice: $6.99, Discount: 10%
  (3, 3, 50000); -- Mango Smoothie, Large, OriginalPrice: $7.99, No Discount
  (4, 1, 30000), -- Cappuccino, Small, OriginalPrice: $3.99, Discount: 20%
  (4, 2, 40000), -- Cappuccino, Medium, OriginalPrice: $4.99, Discount: 10%
  (4, 3, 50000), -- Cappuccino, Large, OriginalPrice: $5.99, No Discount
  (5, 1, 30000), -- Green Tea, Small, OriginalPrice: $2.49, No Discount
  (5, 2, 40000), -- Green Tea, Medium, OriginalPrice: $3.49, Discount: 15%
  (5, 3, 50000), -- Green Tea, Large, OriginalPrice: $4.49, No Discount
  (6, 1, 30000), -- Mango Smoothie, Small, OriginalPrice: $5.99, No Discount
  (6, 2, 40000), -- Mango Smoothie, Medium, OriginalPrice: $6.99, Discount: 10%
  (6, 3, 50000); -- Mango Smoothie, Large, OriginalPrice: $7.99, No Discount
INSERT INTO SUPPLIER (SupplierName, Address, Phone, Status)
VALUES
  ('ABC Suppliers', '123 Main Street, Cityville', '0945679061', 'Active'),
  ('XYZ Distributors', '456 Oak Avenue, Townsville', '0945679061', 'Active'),
  ('LMN Enterprises', '789 Pine Lane, Villageland', '0945679061', 'Active');

INSERT INTO AREA (AreaName, Capacity, Status)
VALUES
  ('Area 1', 50, 'Active'),
  ('Area 2',50, 'Active'),
  ('Area 3',50, 'Inactive');

-- Insert data into BILL table
DECLARE @StartDate DATETIME = '2023-01-01';
DECLARE @EndDate DATETIME = '2023-12-28';

WHILE @StartDate <= @EndDate
BEGIN
  INSERT INTO BILL (BillDate, UserID, TableID, Status, Note, SubTotal, Tax, Total)
  VALUES
    (@StartDate, 1, 1, 'Paid', 'Bill note for ' + CONVERT(NVARCHAR(MAX), @StartDate), 50.0, 5.0, 55.0);

  SET @StartDate = DATEADD(DAY, 1, @StartDate);
END

DECLARE @StartDate DATETIME = '2023-06-29';
DECLARE @EndDate DATETIME = '2023-12-28';
-- Insert data into BILL_DETAIL table
DECLARE @BillID INT;

SET @StartDate = '2023-01-01';

WHILE @StartDate <= @EndDate
BEGIN
  SET @BillID = (SELECT id FROM BILL WHERE BillDate = @StartDate);

  INSERT INTO BILL_DETAIL (BillID, DrinksID, SizeID, Quantity, Rate, Amount)
  VALUES
    (@BillID, 1, 4, 2, 3.99, 7.98),
    (@BillID, 2, 5, 1, 3.49, 3.49),
    (@BillID, 3, 6, 3, 7.99, 23.97);

  SET @StartDate = DATEADD(DAY, 1, @StartDate);
END


select * from _USER
select * from Supplier
select * from _TABLE
select * from DRINKS
select * from DRINKS_SIZE
select * from CATEGORY
select * from BILL_DETAIL