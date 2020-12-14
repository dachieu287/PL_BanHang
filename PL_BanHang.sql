CREATE DATABASE PL_BanHang;
GO

USE PL_BanHang;
GO

CREATE TABLE [Account] (
  [Username] nvarchar(250) NOT NULL,
  [Password] nvarchar(250) NOT NULL,
  [Name] nvarchar(250) NOT NULL,
  [Gender] bit NOT NULL,
  [BirthDay] date NOT NULL,
  [Email] nvarchar(250) NOT NULL,
  [Phone] nvarchar(10) NOT NULL,
  [Address] nvarchar(MAX),
  [Role] nvarchar(50) NOT NULL,
  [Active] bit NOT NULL,
  CONSTRAINT PK_Account PRIMARY KEY (Username)
);

CREATE TABLE [Catalog] (
  [ID] nvarchar(50) NOT NULL,
  [Name] nvarchar(250) NOT NULL,
  CONSTRAINT PK_Catalog PRIMARY KEY (ID)
);

CREATE TABLE [Product] (
  [ID] nvarchar(50) NOT NULL,
  [Name] nvarchar(MAX) NOT NULL,
  [Description] ntext,
  [Image] varbinary(MAX) NOT NULL,
  [Quantity] int NOT NULL DEFAULT 0,
  [Price] decimal(10,0) NOT NULL,
  [CatalogID] nvarchar(50) NOT NULL,
  CONSTRAINT PK_Product PRIMARY KEY (ID),
  CONSTRAINT FK_CatalogProduct FOREIGN KEY (CatalogID) REFERENCES Catalog(ID)
    ON UPDATE CASCADE
);

CREATE TABLE [Combo] (
  [ID] nvarchar(50) NOT NULL,
  [Name] nvarchar(MAX) NOT NULL,
  [Image] varbinary(MAX) NOT NULL,
  [PrevPrice] decimal(10,0),
  [Discount] int,
  [Price] decimal(10,0) NOT NULL,
  [Description] ntext,
  CONSTRAINT PK_Combo PRIMARY KEY (ID)
);

CREATE TABLE [ComboDetail] (
  [ComboID] nvarchar(50) NOT NULL,
  [ProductID] nvarchar(50) NOT NULL,
  [Quantity] int NOT NULL,
  CONSTRAINT PK_ComboDetails PRIMARY KEY (ComboID, ProductID),
  CONSTRAINT FK_ComboComboDetails FOREIGN KEY (ComboID) REFERENCES Combo(ID)
    ON UPDATE CASCADE
	ON DELETE CASCADE,
  CONSTRAINT FK_ProductComboDetails FOREIGN KEY (ProductID) REFERENCES Product(ID)
    ON UPDATE CASCADE
);

CREATE TABLE [Bill] (
  [ID] int NOT NULL IDENTITY,
  [Name] nvarchar(250),
  [Address] nvarchar(max),
  [Phone] nvarchar(10),
  [Datetime] datetime NOT NULL DEFAULT GETDATE(),
  [Total] decimal(10,0) NOT NULL,
  [Status] int NOT NULL,
  CONSTRAINT PK_Bill PRIMARY KEY (ID)
);

CREATE TABLE [BillDetail] (
  [ID] int NOT NULL IDENTITY,
  [BillID] int NOT NULL,
  [ProductID] nvarchar(50),
  [ComboID] nvarchar(50),
  [Price] decimal(10,0) NOT NULL,
  [Quantity] int NOT NULL,
  CONSTRAINT PK_BillDetails PRIMARY KEY (ID),
  CONSTRAINT FK_BillBillDetails FOREIGN KEY (BillID) REFERENCES Bill(ID),
  CONSTRAINT FK_ProductBillDetails FOREIGN KEY (ProductID) REFERENCES Product(ID)
    ON UPDATE CASCADE,
  CONSTRAINT FK_ComboBillDetails FOREIGN KEY (ComboID) REFERENCES Combo(ID)
    ON UPDATE CASCADE,
);
GO

INSERT INTO Account(Username, Password, Name, Gender, BirthDay, Email, Phone, Address, Role, Active)
VALUES ('admin', '123456', N'Admin', 1, '1999/07/28', 'admin@email.com', '0374480249', N'AAA BBB CCC', 'admin', 1);