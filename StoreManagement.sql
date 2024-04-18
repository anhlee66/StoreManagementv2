drop database if exists StoreManagement;
create database StoreManagement;
use StoreManagement;

create login storeManagement with password='1234', Check_Policy=off;

drop table if exists InvoiceDetails;
drop table if exists Invocies;
drop table if exists ReceiptDetails;
drop table if exists Receipts;
drop table if exists Accounts;
drop table if exists Employees;
drop table if exists Products;
drop table if exists Categories;



-- create login

create table Categories
(
	Id int primary key identity,
	Name nvarchar(100)  COLLATE Vietnamese_CI_AI not null,
	Unit nvarchar(50)COLLATE Vietnamese_CI_AI  not null ,
);
go

select * from Categories;
create table Products
(
	Id int primary key identity,
	Name nvarchar(200)  COLLATE Vietnamese_CI_AI not null,
	Quantity int check(Quantity>=0) not null,
	Import money check(Import>0) not null,
	Price money check(Price >0) not null,
	Supplier nvarchar(100) COLLATE Vietnamese_CI_AI default '',
	CategoryId int not null,
	Foreign key (CategoryId) references Categories(Id)
);
go

create table Employees(
	Id int primary key identity,
	Name nvarchar(200) COLLATE Vietnamese_CI_AI not null,
	Contact varchar(50) not null,
	Gender bit not null,
	Address nvarchar(200) COLLATE Vietnamese_CI_AI,
);
go

create table Accounts(
	Id int primary key identity,
	LoginName varchar(100) not null unique,
	Password varchar(100) not null,
	EmployeeId int not null,
	Foreign key (EmployeeId) references Employees(Id)
);

drop table if exists Invoices;
create table Invoices(
	Id int primary key identity,
	DataCreated date not null  default GETDATE(),
	EmployeeId int not null,
	Foreign key (EmployeeId) references Employees(Id)
);
go
drop table if exists InvoiceDetails;
create table InvoiceDetails(
	InvoiceId int not null,
	ProductId int not null,
	Amount int check(Amount > 0) not null,
	Price money not null check(Price > 0),
	primary key(InvoiceId, ProductId),
	Foreign key (InvoiceId) references Invoices(Id),
	Foreign key (ProductId) references Products(Id)
);
go

create table Receipts(
	Id int primary key identity,
	DataCreated date not null default GETDATE(),
	EmployeeId int not null,
	Foreign key (EmployeeId) references Employees(Id)
);
go

create table ReceiptDetails(
	ReceiptId int not null,
	ProductId int not null,
	Amount int Check(Amount > 0) ,
	Import money check( Import >0)
	Foreign key (ReceiptId) references Receipts(Id),
	Foreign key (ProductId) references Products(Id)
);
go

--insert data



-- Thêm dữ liệu vào bảng Categories
insert into Categories (Name, Unit) values 
(N'Xi măng', N'Bao'),
(N'Gạch', N'Viên'),
(N'Sắt thép', N'Kg'),
(N'Lát gạch', N'Hộp'),
(N'Nước Sơn', N'Lít'),
(N'Cát', N'Mét Khối'),
(N'Mái nhà', N'Tấm'),
(N'Cửa chính', N'Cái'),
(N'Cửa sổ', N'Cái');

--update Categories set unit=N'Viên' where id=2;
select * from Categories;
-- Thêm dữ liệu vào bảng Products
insert into Products (Name, Quantity, Import, Price, Supplier, CategoryId) values
(N'Bao xi măng Holcim 50kg', 100, 100000, 150000, N'Công ty xi măng Holcim Việt Nam', 1),
(N'Gạch Viglacera 10x10cm', 5000, 500, 1000, N'Công ty Viglacera', 2),
(N'Sắt thép Hoà Phát 3mm', 2000, 120000, 250000, N'Công ty TNHH Sắt thép Hoà Phát', 3),
(N'Lát gạch TASA 60x60cm', 300, 80000, 120000, N'Công ty Cổ phần Lạnh - Điện - Nước Việt Nam', 4),
(N'Sơn Nippon 5 lít', 200, 40000, 80000, N'Công ty TNHH Nippon Paint Việt Nam', 5),
(N'Cát xây xịn 1m³', 50, 400000, 800000, N'Công ty TNHH MTV Xây dựng và Vật liệu xây dựng sạch Việt Nam', 6),
(N'Gỗ An Cường 1m³', 30, 1500000, 2000000, N'Công ty Cổ phần Gỗ An Cường', 7),
(N'Mái nhà Phú Lợi 1 tấm', 100, 100000, 200000, N'Công ty TNHH Sản xuất và Thương mại Phú Lợi', 8),
(N'Cửa gỗ Hòa Phát 1 cánh', 50, 300000, 500000, N'Công ty TNHH SX và TM Gỗ Hòa Phát', 9),
(N'Cửa sổ Eurowindow 1 bộ', 50, 250000, 400000, N'Công ty Cổ phần Eurowindow', 9),
(N'Đá xây dựng 1m³', 80, 350000, 500000, N'Công ty TNHH Đá xây dựng Việt Nam', 6),
(N'Kẽm tấm 0.5mm', 200, 200000, 300000, N'Công ty TNHH Tôn thép Kẽm Việt Nam', 3),
(N'Gạch mosaic 5x5cm', 1000, 150, 300, N'Công ty TNHH MTV Gạch mosaic Việt Nam', 2),
(N'Gạch lát 20x20cm', 200, 100, 200, N'Công ty TNHH SX Gạch lát Việt Nam', 4),
(N'Ốp lát gạch 30x60cm', 150, 200, 400, N'Công ty TNHH SX Ốp lát gạch Việt Nam', 4),
(N'Thạch anh tự nhiên 1m²', 50, 500000, 1000000, N'Công ty TNHH Khai thác và Chế biến đá Thạch anh Việt Nam', 6),
(N'Kính cường lực 10mm', 80, 80000, 150000, N'Công ty TNHH SX Kính cường lực Việt Nam', 9),
(N'Cát sông 1m³', 60, 250000, 400000, N'Công ty TNHH MTV Cát sông Việt Nam', 6),
(N'Gỗ thông 1m³', 40, 1200000, 1800000, N'Công ty TNHH Gỗ thông Việt Nam', 7),
(N'Gạch không nung 10x20cm', 3000, 50, 100, N'Công ty TNHH SX Gạch không nung Việt Nam', 2),
(N'Mái che di động 1m²', 70, 200000, 350000, N'Công ty TNHH SX Mái che di động Việt Nam', 7),
(N'Cửa cuốn 3m', 30, 700000, 1000000, N'Công ty TNHH SX Cửa cuốn Việt Nam', 9),
(N'Gạch granite 60x60cm', 200, 300, 600, N'Công ty TNHH SX Gạch granite Việt Nam', 2),
(N'Bê tông ready-mix 1m³', 100, 400000, 700000, N'Công ty TNHH SX Bê tông ready-mix Việt Nam', 6),
(N'Máy phát điện 5KW', 10, 8000000, 12000000, N'Công ty TNHH SX Máy phát điện Việt Nam', 9);

-- Thêm dữ liệu vào bảng Employees
insert into Employees (Name, Contact, Gender, Address) values
(N'Nguyễn Văn A', '0987654321', 1, N'Hà Nội'),
(N'Phạm Thị B', '0123456789', 0, N'Hồ Chí Minh'),
(N'Trần Văn C', '0901234567', 1, N'Đà Nẵng'),
(N'Lê Thị D', '0398765432', 0, N'Hải Phòng');

-- Thêm dữ liệu vào bảng Accounts
insert into Accounts (LoginName, Password, EmployeeId) values
('nvana', '123456', 1),
('ptb', 'abcdef', 2),
('tvc', 'uvwxyz', 3),
('ltd', '987654', 4);
select * from accounts;
-- Thêm dữ liệu vào bảng Invoices
insert into Invoices (EmployeeId) values
(1),
(2),
(3),
(4);

-- Thêm dữ liệu vào bảng InvoiceDetails
insert into InvoiceDetails (InvoiceId, ProductId, Amount, Price) values
(1, 1, 5, 75.00),
(1, 2, 100, 30.00),
(2, 3, 50, 125.00),
(2, 4, 10, 120.00),
(3, 5, 20, 160.00),
(3, 6, 10, 800.00),
(4, 7, 2, 400.00),
(4, 8, 5, 100.00);

-- Thêm dữ liệu vào bảng Receipts
insert into Receipts (EmployeeId) values
(1),
(2),
(3),
(4);

-- Thêm dữ liệu vào bảng ReceiptDetils 
insert into ReceiptDetails (ReceiptId, ProductId, Amount, Import) values
(1, 1, 2, 21.00),
(1, 2, 50, 15.00),
(2, 3, 20, 1.00),
(2, 4, 5, 8.00),
(3, 5, 10, 4.00),
(3, 6, 5, 40.00),
(4, 7, 1, 100.00),
(4, 8, 3, 150.00);
select * from invoices;

select * from Products;

Select * from Accounts where LoginName='nvana';
Select p.Name,c.Name,Quantity,Import, Price,Supplier from  Products p 
inner join Categories c on c.Id = p.Id

select * from products where name like '%cUa%';
select * from Categories where Id not in(select distinct CategoryId from Products);

select id from Products where 
	Id not in (Select ProductId from InvoiceDetails) and
	Id not in (Select ProductId from ReceiptDetails )and Quantity = 0;

select * from Products where Id!=1;


;

drop procedure if exists GetInvoice;
create procedure GetInvoice
as
begin
	select i1.Id as Id, DataCreated, Employee,TotalPrice,TotalAmount from 
	(select distinct i.Id as Id, DataCreated,Name as Employee from Invoices i 
		inner join InvoiceDetails id on i.Id = id.InvoiceId
		inner join Employees e on e.Id = i.EmployeeId) i1
	inner join 
	(select i.Id as Id,Sum(Price*Amount) as TotalPrice,Sum(Amount) as TotalAmount from Invoices i 
		inner join InvoiceDetails id on i.Id = id.InvoiceId
		inner join Employees e on e.Id = i.EmployeeId
	group by i.Id) i2 on i1.Id = i2.Id
	--where i1.Id = @Id;
	
end;
go



exec GetInvoice;

create procedure GetStatictis
as
begin
	select Sum(Amount*p.Price - Amount*p.Import) as profit, Sum(Amount * P.Price) as revenue  from Invoices i 
		inner join InvoiceDetails id on i.Id = id.InvoiceId
		inner join Employees e on e.Id = i.EmployeeId
		inner join Products p on id.ProductId = p.Id
end;
go

Exec GetStatictis;


create procedure GetTopProductsSale(@number int)
as
begin
	select   p.Id,Name ,sum(Amount) as Amount from Products p
		inner join InvoiceDetails id on id.ProductId = p.Id
	group by p.Id,Name
	order by sum(Amount) desc;
end;
go
select * from Products
select * from InvoiceDetails;

select * from employees;
insert into Employees values(N'Dương Minh Nhí','0765189055',1,'Cần Thơ');
select * from Accounts;
insert into Accounts values('dnhi','12345',5);