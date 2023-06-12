CREATE DATABASE EMedicine;
USE EMedicine;

CREATE TABLE Users (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  FirstName VARCHAR(100),
  LastName VARCHAR(100),
  Password VARCHAR(100),
  Email VARCHAR(100),
  Fund DECIMAL(18, 2),
  Type VARCHAR(100),
  Status INT,
  Createdon DATETIME
);

CREATE TABLE Medicines (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  Name VARCHAR(100),
  Manufacturer VARCHAR(100),
  UnitPrice DECIMAL(18, 2),
  Discount DECIMAL(18, 2),
  Quantity INT,
  ExpDate DATETIME,
  ImageUrl VARCHAR(100),
  Status INT
);

CREATE TABLE Cart (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  UserId INT,
  MedicineID INT,
  UnitPrice DECIMAL(18, 2),
  Discount DECIMAL(18, 2),
  Quantity INT,
  TotalPrice DECIMAL(18, 2),
  FOREIGN KEY (UserId) REFERENCES Users(ID),
  FOREIGN KEY (MedicineID) REFERENCES Medicines(ID)
);

CREATE TABLE Orders (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  UserID INT,
  OrderNo VARCHAR(100),
  OrderTotal DECIMAL(18, 2),
  OrderStatus VARCHAR(100),
  FOREIGN KEY (UserID) REFERENCES Users(ID)
);

CREATE TABLE OrderItems (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  OrderID INT,
  MedicineID INT,
  UnitPrice DECIMAL(18, 2),
  Discount DECIMAL(18, 2),
  Quantity INT,
  TotalPrice DECIMAL(18, 2),
  FOREIGN KEY (OrderID) REFERENCES Orders(ID),
  FOREIGN KEY (MedicineID) REFERENCES Medicines(ID)
);
