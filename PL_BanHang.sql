CREATE DATABASE PL_BanHang;
GO

USE PL_BanHang;
GO

CREATE TABLE [Account] (
  [ID] int NOT NULL IDENTITY,
  [Email] nvarchar(250) NOT NULL UNIQUE,
  [Password] nvarchar(250) NOT NULL,
  [Name] nvarchar(250) NOT NULL,
  [Gender] bit NOT NULL,
  [BirthDay] date NOT NULL,
  [Phone] nvarchar(10) NOT NULL,
  [Address] nvarchar(MAX),
  [JoinDate] date NOT NULL,
  [Role] nvarchar(50) NOT NULL,
  [Active] bit NOT NULL,
  CONSTRAINT PK_Account PRIMARY KEY (ID)
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
  [CatalogID] nvarchar(50) NOT NULL,
  CONSTRAINT PK_Product PRIMARY KEY (ID),
  CONSTRAINT FK_CatalogProduct FOREIGN KEY (CatalogID) REFERENCES Catalog(ID)
    ON UPDATE CASCADE
);

CREATE TABLE [Combo] (
  [ID] nvarchar(50) NOT NULL,
  [Name] nvarchar(MAX) NOT NULL,
  [Image] varbinary(MAX) NOT NULL,
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

CREATE TABLE [Price] (
  [ID] int NOT NULL IDENTITY,
  [ProductID] nvarchar(50),
  [ComboID] nvarchar(50),
  [FromDatetime] datetime NOT NULL DEFAULT GETDATE(),
  [ToDatetime] datetime,
  [PrevPrice] decimal (10,0),
  [Discount] int,
  [Price] decimal(10,0) NOT NULL,
  CONSTRAINT PK_Price PRIMARY KEY (ID),
  CONSTRAINT FK_ProductPrice FOREIGN KEY (ProductID) REFERENCES Product(ID)
    ON UPDATE CASCADE
    ON DELETE CASCADE,
  CONSTRAINT FK_ComboPrice FOREIGN KEY (ComboID) REFERENCES Combo(ID)
    ON UPDATE CASCADE
    ON DELETE CASCADE,
);

CREATE TABLE [Bill] (
  [ID] int NOT NULL IDENTITY,
  [AccountEmail] nvarchar(250) NOT NULL,
  [Datetime] datetime NOT NULL DEFAULT GETDATE(),
  [Total] decimal(10,0) NOT NULL,
  [Status] int NOT NULL,
  CONSTRAINT PK_Bill PRIMARY KEY (ID),
  CONSTRAINT FK_AccountEmailBill FOREIGN KEY (AccountEmail) REFERENCES Account(Email)
);

CREATE TABLE [BillDetail] (
  [ID] int NOT NULL IDENTITY,
  [BillID] int NOT NULL,
  [ProductID] nvarchar(50),
  [ComboID] nvarchar(50),
  [PriceID] int NOT NULL,
  [Quantity] int NOT NULL,
  CONSTRAINT PK_BillDetails PRIMARY KEY (ID),
  CONSTRAINT FK_BillBillDetails FOREIGN KEY (BillID) REFERENCES Bill(ID),
  CONSTRAINT FK_ProductBillDetails FOREIGN KEY (ProductID) REFERENCES Product(ID)
    ON UPDATE CASCADE,
  CONSTRAINT FK_ComboBillDetails FOREIGN KEY (ComboID) REFERENCES Combo(ID)
    ON UPDATE CASCADE,
  CONSTRAINT FK_PriceBillDetails FOREIGN KEY (PriceID) REFERENCES Price(ID)
);
GO

INSERT INTO Account(Email, Password, Name, Gender, BirthDay, Phone, Address, JoinDate, Role, Active)
VALUES ('admin@email.com', '123456', N'Admin', 1, '1999/07/28', '0374480249', N'AAA BBB CCC', GETDATE(), 'admin', 1);