drop table Category;

Create table Category(
CategoryID INT PRIMARY KEY IDENTITY(1,1) not null,
CategoryName varchar(250) not null,
)

drop table Product;

create table Product(
ProductID INT PRIMARY KEY IDENTITY(1,1) not null,
ProductName varchar(250) not null,
CategoryID INT not null,
FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
)

drop table Customer;

create table Customer(
CustomerID INT PRIMARY KEY IDENTITY(1,1) not null,
CustomerName varchar(250) not null,
)

drop table OrderLine;

create table OrderLine(
OrderLineID INT PRIMARY KEY IDENTITY(1,1) not null,
OrderLineName varchar(250) not null,
OrderTableId int,
FOREIGN KEY (OrderTableId) REFERENCES OrderTable(OrderTableId)
)

drop table OrderTable;

create table OrderTable(
OrderTableID INT PRIMARY KEY IDENTITY(1,1) not null,
CustomerID  INT,
FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
)

drop table ProductOrder;

create table ProductOrder(
ProductOrderID INT PRIMARY KEY IDENTITY(1,1) not null,
OrderTableID Int,
FOREIGN KEY (OrderTableID) REFERENCES OrderTable(OrderTableID),
ProductID Int,
FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
)