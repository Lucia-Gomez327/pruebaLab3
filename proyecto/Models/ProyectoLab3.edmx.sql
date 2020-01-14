
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/20/2019 16:37:03
-- Generated from EDMX file: C:\Users\lenovo\Desktop\pruebaLab3-master\proyecto\Models\EntityBD.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ProyectoLab3];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[fk_person_client]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Client] DROP CONSTRAINT [fk_person_client];
GO
IF OBJECT_ID(N'[dbo].[fk_person_employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [fk_person_employee];
GO
IF OBJECT_ID(N'[dbo].[fk_person_employer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employer] DROP CONSTRAINT [fk_person_employer];
GO
IF OBJECT_ID(N'[dbo].[fk_product_sale]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SaleProducts] DROP CONSTRAINT [fk_product_sale];
GO
IF OBJECT_ID(N'[dbo].[fk_sale_client]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sale] DROP CONSTRAINT [fk_sale_client];
GO
IF OBJECT_ID(N'[dbo].[fk_sale_employeer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sale] DROP CONSTRAINT [fk_sale_employeer];
GO
IF OBJECT_ID(N'[dbo].[fk_sale_product]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SaleProducts] DROP CONSTRAINT [fk_sale_product];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Client]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Client];
GO
IF OBJECT_ID(N'[dbo].[Code]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Code];
GO
IF OBJECT_ID(N'[dbo].[Employee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employee];
GO
IF OBJECT_ID(N'[dbo].[Employer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employer];
GO
IF OBJECT_ID(N'[dbo].[Person]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Person];
GO
IF OBJECT_ID(N'[dbo].[Product]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Product];
GO
IF OBJECT_ID(N'[dbo].[Sale]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sale];
GO
IF OBJECT_ID(N'[dbo].[SaleProducts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SaleProducts];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [idPerson] int  NOT NULL
);
GO

-- Creating table 'Codes'
CREATE TABLE [dbo].[Codes] (
    [Id] int  NOT NULL,
    [key] nchar(10)  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [IdPerson] int  NOT NULL,
    [hireDate] datetime  NULL,
    [payDate] datetime  NULL,
    [salary] decimal(18,0)  NULL,
    [password] nvarchar(50)  NULL,
    [userName] nvarchar(50)  NULL
);
GO

-- Creating table 'Employers'
CREATE TABLE [dbo].[Employers] (
    [idPerson] int  NOT NULL,
    [password] nvarchar(50)  NULL,
    [userName] nvarchar(50)  NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [idPerson] int IDENTITY(1,1) NOT NULL,
    [firstName] nchar(30)  NOT NULL,
    [lastName] nchar(30)  NOT NULL,
    [email] nchar(50)  NOT NULL,
    [dress] nchar(50)  NULL,
    [telephone] nchar(10)  NULL,
    [sex] nchar(9)  NOT NULL,
    [documentNumber] nchar(8)  NOT NULL,
    [state] int  NOT NULL,
    [type] nchar(28)  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [idProduct] int IDENTITY(1,1) NOT NULL,
    [cant] int  NOT NULL,
    [price] decimal(10,5)  NOT NULL,
    [description] nchar(80)  NULL,
    [barcode] decimal(8,0)  NOT NULL,
    [categorie] nchar(80)  NULL,
    [state] int  NOT NULL
);
GO

-- Creating table 'Sales'
CREATE TABLE [dbo].[Sales] (
    [IdSale] int IDENTITY(1,1) NOT NULL,
    [idPerson] int  NOT NULL,
    [idClient] int  NOT NULL,
    [idProduct] int  NOT NULL,
    [summary] decimal(18,0)  NOT NULL,
    [saleDate] datetime  NOT NULL,
    [saleNumber] nchar(10)  NOT NULL,
    [state] int  NOT NULL
);
GO

-- Creating table 'SaleProducts'
CREATE TABLE [dbo].[SaleProducts] (
    [idProduct] int  NOT NULL,
    [idSale] int  NOT NULL,
    [cant] int  NOT NULL,
    [summary] decimal(18,0)  NOT NULL,
    [idSaleProduct] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [idPerson] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([idPerson] ASC);
GO

-- Creating primary key on [Id] in table 'Codes'
ALTER TABLE [dbo].[Codes]
ADD CONSTRAINT [PK_Codes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [IdPerson] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([IdPerson] ASC);
GO

-- Creating primary key on [idPerson] in table 'Employers'
ALTER TABLE [dbo].[Employers]
ADD CONSTRAINT [PK_Employers]
    PRIMARY KEY CLUSTERED ([idPerson] ASC);
GO

-- Creating primary key on [idPerson] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([idPerson] ASC);
GO

-- Creating primary key on [idProduct] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([idProduct] ASC);
GO

-- Creating primary key on [IdSale] in table 'Sales'
ALTER TABLE [dbo].[Sales]
ADD CONSTRAINT [PK_Sales]
    PRIMARY KEY CLUSTERED ([IdSale] ASC);
GO

-- Creating primary key on [idSaleProduct] in table 'SaleProducts'
ALTER TABLE [dbo].[SaleProducts]
ADD CONSTRAINT [PK_SaleProducts]
    PRIMARY KEY CLUSTERED ([idSaleProduct] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [idPerson] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [fk_person_client]
    FOREIGN KEY ([idPerson])
    REFERENCES [dbo].[People]
        ([idPerson])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idClient] in table 'Sales'
ALTER TABLE [dbo].[Sales]
ADD CONSTRAINT [fk_sale_client]
    FOREIGN KEY ([idClient])
    REFERENCES [dbo].[Clients]
        ([idPerson])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_sale_client'
CREATE INDEX [IX_fk_sale_client]
ON [dbo].[Sales]
    ([idClient]);
GO

-- Creating foreign key on [IdPerson] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [fk_person_employee]
    FOREIGN KEY ([IdPerson])
    REFERENCES [dbo].[People]
        ([idPerson])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idPerson] in table 'Employers'
ALTER TABLE [dbo].[Employers]
ADD CONSTRAINT [fk_person_employer]
    FOREIGN KEY ([idPerson])
    REFERENCES [dbo].[People]
        ([idPerson])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idPerson] in table 'Sales'
ALTER TABLE [dbo].[Sales]
ADD CONSTRAINT [fk_sale_employeer]
    FOREIGN KEY ([idPerson])
    REFERENCES [dbo].[Employers]
        ([idPerson])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_sale_employeer'
CREATE INDEX [IX_fk_sale_employeer]
ON [dbo].[Sales]
    ([idPerson]);
GO

-- Creating foreign key on [idProduct] in table 'SaleProducts'
ALTER TABLE [dbo].[SaleProducts]
ADD CONSTRAINT [fk_sale_product]
    FOREIGN KEY ([idProduct])
    REFERENCES [dbo].[Products]
        ([idProduct])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_sale_product'
CREATE INDEX [IX_fk_sale_product]
ON [dbo].[SaleProducts]
    ([idProduct]);
GO

-- Creating foreign key on [idSale] in table 'SaleProducts'
ALTER TABLE [dbo].[SaleProducts]
ADD CONSTRAINT [fk_product_sale]
    FOREIGN KEY ([idSale])
    REFERENCES [dbo].[Sales]
        ([IdSale])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_product_sale'
CREATE INDEX [IX_fk_product_sale]
ON [dbo].[SaleProducts]
    ([idSale]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------