
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/28/2016 14:11:30
-- Generated from EDMX file: C:\Users\erik.aberg\Source\Repos\effective-adventure\CreateCookiesSolutionMVC\CreateCookies\CreateCookiesModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CreateCookiesC#];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [CNumber] int IDENTITY(1,1) NOT NULL,
    [CName] nvarchar(max)  NOT NULL,
    [CAddress] nvarchar(max)  NOT NULL,
    [CPostalAddress] nvarchar(max)  NOT NULL,
    [CCountry] nvarchar(max)  NOT NULL,
    [CEmail] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [ONumber] int IDENTITY(1,1) NOT NULL,
    [IsDelivered] bit  NOT NULL,
    [ExpectedDeliveryDate] datetime  NOT NULL,
    [CustomerCNumber] int  NOT NULL
);
GO

-- Creating table 'Orderspecifications'
CREATE TABLE [dbo].[Orderspecifications] (
    [PalletQuantity] nvarchar(max)  NOT NULL,
    [OrderONumber] int  NOT NULL,
    [ProductPNumber] int  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [PNumber] int IDENTITY(1,1) NOT NULL,
    [PName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pallets'
CREATE TABLE [dbo].[Pallets] (
    [PalletID] int IDENTITY(1,1) NOT NULL,
    [PalletTime] datetime  NOT NULL,
    [OrderONumber] int  NOT NULL,
    [ProductPNumber] int  NOT NULL
);
GO

-- Creating table 'Recipes'
CREATE TABLE [dbo].[Recipes] (
    [RQuantity] int  NOT NULL,
    [IngredientINumber] int  NOT NULL,
    [ProductPNumber] int  NOT NULL
);
GO

-- Creating table 'Ingredients'
CREATE TABLE [dbo].[Ingredients] (
    [INumber] int IDENTITY(1,1) NOT NULL,
    [SupplierSNumber] int  NOT NULL
);
GO

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [SNumber] int IDENTITY(1,1) NOT NULL,
    [SName] nvarchar(max)  NOT NULL,
    [SLocation] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Produceds'
CREATE TABLE [dbo].[Produceds] (
    [PTime] datetime  NOT NULL,
    [PName] nvarchar(max)  NOT NULL,
    [PPallet] nvarchar(max)  NOT NULL,
    [ProductPNumber] int  NOT NULL,
    [OrderONumber] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CNumber] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([CNumber] ASC);
GO

-- Creating primary key on [ONumber] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([ONumber] ASC);
GO

-- Creating primary key on [OrderONumber], [ProductPNumber] in table 'Orderspecifications'
ALTER TABLE [dbo].[Orderspecifications]
ADD CONSTRAINT [PK_Orderspecifications]
    PRIMARY KEY CLUSTERED ([OrderONumber], [ProductPNumber] ASC);
GO

-- Creating primary key on [PNumber] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([PNumber] ASC);
GO

-- Creating primary key on [PalletID] in table 'Pallets'
ALTER TABLE [dbo].[Pallets]
ADD CONSTRAINT [PK_Pallets]
    PRIMARY KEY CLUSTERED ([PalletID] ASC);
GO

-- Creating primary key on [IngredientINumber], [ProductPNumber] in table 'Recipes'
ALTER TABLE [dbo].[Recipes]
ADD CONSTRAINT [PK_Recipes]
    PRIMARY KEY CLUSTERED ([IngredientINumber], [ProductPNumber] ASC);
GO

-- Creating primary key on [INumber] in table 'Ingredients'
ALTER TABLE [dbo].[Ingredients]
ADD CONSTRAINT [PK_Ingredients]
    PRIMARY KEY CLUSTERED ([INumber] ASC);
GO

-- Creating primary key on [SNumber] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([SNumber] ASC);
GO

-- Creating primary key on [PTime] in table 'Produceds'
ALTER TABLE [dbo].[Produceds]
ADD CONSTRAINT [PK_Produceds]
    PRIMARY KEY CLUSTERED ([PTime] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomerCNumber] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_CustomerOrder]
    FOREIGN KEY ([CustomerCNumber])
    REFERENCES [dbo].[Customers]
        ([CNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerOrder'
CREATE INDEX [IX_FK_CustomerOrder]
ON [dbo].[Orders]
    ([CustomerCNumber]);
GO

-- Creating foreign key on [OrderONumber] in table 'Orderspecifications'
ALTER TABLE [dbo].[Orderspecifications]
ADD CONSTRAINT [FK_OrderOrderspecification]
    FOREIGN KEY ([OrderONumber])
    REFERENCES [dbo].[Orders]
        ([ONumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ProductPNumber] in table 'Orderspecifications'
ALTER TABLE [dbo].[Orderspecifications]
ADD CONSTRAINT [FK_ProductOrderspecification]
    FOREIGN KEY ([ProductPNumber])
    REFERENCES [dbo].[Products]
        ([PNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductOrderspecification'
CREATE INDEX [IX_FK_ProductOrderspecification]
ON [dbo].[Orderspecifications]
    ([ProductPNumber]);
GO

-- Creating foreign key on [OrderONumber] in table 'Pallets'
ALTER TABLE [dbo].[Pallets]
ADD CONSTRAINT [FK_OrderPallet]
    FOREIGN KEY ([OrderONumber])
    REFERENCES [dbo].[Orders]
        ([ONumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderPallet'
CREATE INDEX [IX_FK_OrderPallet]
ON [dbo].[Pallets]
    ([OrderONumber]);
GO

-- Creating foreign key on [ProductPNumber] in table 'Pallets'
ALTER TABLE [dbo].[Pallets]
ADD CONSTRAINT [FK_PalletProduct]
    FOREIGN KEY ([ProductPNumber])
    REFERENCES [dbo].[Products]
        ([PNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PalletProduct'
CREATE INDEX [IX_FK_PalletProduct]
ON [dbo].[Pallets]
    ([ProductPNumber]);
GO

-- Creating foreign key on [IngredientINumber] in table 'Recipes'
ALTER TABLE [dbo].[Recipes]
ADD CONSTRAINT [FK_IngredientRecipe]
    FOREIGN KEY ([IngredientINumber])
    REFERENCES [dbo].[Ingredients]
        ([INumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [SupplierSNumber] in table 'Ingredients'
ALTER TABLE [dbo].[Ingredients]
ADD CONSTRAINT [FK_SupplierIngredient]
    FOREIGN KEY ([SupplierSNumber])
    REFERENCES [dbo].[Suppliers]
        ([SNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SupplierIngredient'
CREATE INDEX [IX_FK_SupplierIngredient]
ON [dbo].[Ingredients]
    ([SupplierSNumber]);
GO

-- Creating foreign key on [ProductPNumber] in table 'Produceds'
ALTER TABLE [dbo].[Produceds]
ADD CONSTRAINT [FK_ProductProduced]
    FOREIGN KEY ([ProductPNumber])
    REFERENCES [dbo].[Products]
        ([PNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductProduced'
CREATE INDEX [IX_FK_ProductProduced]
ON [dbo].[Produceds]
    ([ProductPNumber]);
GO

-- Creating foreign key on [OrderONumber] in table 'Produceds'
ALTER TABLE [dbo].[Produceds]
ADD CONSTRAINT [FK_OrderProduced]
    FOREIGN KEY ([OrderONumber])
    REFERENCES [dbo].[Orders]
        ([ONumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderProduced'
CREATE INDEX [IX_FK_OrderProduced]
ON [dbo].[Produceds]
    ([OrderONumber]);
GO

-- Creating foreign key on [ProductPNumber] in table 'Recipes'
ALTER TABLE [dbo].[Recipes]
ADD CONSTRAINT [FK_ProductRecipe]
    FOREIGN KEY ([ProductPNumber])
    REFERENCES [dbo].[Products]
        ([PNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductRecipe'
CREATE INDEX [IX_FK_ProductRecipe]
ON [dbo].[Recipes]
    ([ProductPNumber]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------