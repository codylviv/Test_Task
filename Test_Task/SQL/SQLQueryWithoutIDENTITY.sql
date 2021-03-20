--Create database ‘MyShop’
CREATE DATABASE MyShop;
USE  MyShop;
--Create tables Products, Categories,Suppliers
CREATE TABLE Products (ProductID int PRIMARY KEY NOT NULL,
ProductName varchar(50) NOT NULL,
SupplierID int NOT NULL,
CategoryID int NOT NULL,
Price money NOT NULL);

CREATE TABLE Suppliers(SupplierID int PRIMARY KEY NOT NULL,
SupplierName varchar(50) NOT NULL,
City varchar(20) NOT NULL,
Country varchar(20) NOT NULL)

CREATE TABLE Categories(CategoryID int PRIMARY KEY NOT NULL,
CategoryName varchar(20) NOT NULL,
Discription text NOT NULL)

ALTER TABLE Products
ADD FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID);
ALTER TABLE Products
ADD FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID);
--Insert Data
INSERT INTO Suppliers VALUES (1,'Exotic Liquid','London','UK'),
(2,'New Orleans Cajun Delights','New Orleans','USA'),
(3,'Grandma Kelly’s Homestead','Ann Arbor','USA'),
(4,'Tokyo Traders','Tokyo','Japan'),
(5,'Cooperativa de Quesos ‘Las Cabras’','Oviedo','Spain');

INSERT INTO Categories VALUES 
(1,'Beverages','Soft drinks, coffees, teas, beers, and ales'),
(2,'Condiments','Sweet and savory sauces, relishes, spreads, and seasonings'),
(3,'Confections','Desserts, candies, and sweet breads'),
(4,'Dairy Products','Cheeses'),
(5,'Grains/Cereals','Breads, crackers, pasta, and cereal');

INSERT INTO Products VALUES (1,'Chais',1,1,18.00),
(2,'Chang',1,1,19.00),
(3,'Aniseed Syrup',1,2,10.00),
(4,'Chef Anton’s Cajun Seasoning',2,2,22.00),
(5,'Chef Anton’s Gumbo Mix',2,2,21.35);


--Select product with product name that begins with ‘C’
SELECT * FROM Products WHERE ProductName LIKE 'C%';
--Select product with the smallest price
SELECT top 1 * FROM Products Order by price; 
--Select cost of all products from the USA.
SELECT ProductName,Price FROM Products
join Suppliers on Products.SupplierID=Suppliers.SupplierID 
Where Suppliers.Country = 'USA'
--Select suppliers that supply Condiments.
SELECT DISTINCT (Suppliers.SupplierID),SupplierName, City,Country FROM Suppliers
join Products on Products.SupplierID=Suppliers.SupplierID
join Categories on Categories.CategoryID=Products.CategoryID
Where Categories.CategoryName = 'Condiments';
--Add to database new supplier with name: ‘Norske Meierier’, city: ‘Lviv’, country: ‘Ukraine’ which
--will supply new product with name: ‘Green tea’, price: 10, and related to category with name:
--‘Beverages’.
BEGIN 
DECLARE @SuplierID int;  
DECLARE @CategoryID int; 
DECLARE @SuplierIdToInsert int; 
DECLARE @ProductIdToInsert int; 
SELECT @CategoryID = CategoryID 
  FROM Categories
 WHERE CategoryName = 'Beverages';
 SELECT @SuplierIdToInsert = MAX(SupplierID)+1 FROM Suppliers
 SELECT @ProductIdToInsert = MAX(Products.ProductID)+1 FROM Products
INSERT INTO Suppliers VALUES(@SuplierIdToInsert,'Norske Meierier','Lviv','Ukraine' );
INSERT INTO Products VALUES(@ProductIdToInsert,'Green tea',@SuplierIdToInsert,@CategoryID,10);
END
