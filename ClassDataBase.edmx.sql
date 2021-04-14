
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/29/2021 08:49:43
-- Generated from EDMX file: C:\Users\melan\Desktop\Y2Sem2Programming\Sem2Project\ClassDataBase.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ClassInfo];
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

-- Creating table 'ClassTypes'
CREATE TABLE [dbo].[ClassTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Weapons'
CREATE TABLE [dbo].[Weapons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [WeaponType] nvarchar(max)  NOT NULL,
    [WeaponImage] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'WeaponClassType'
CREATE TABLE [dbo].[WeaponClassType] (
    [Weapons_Id] int  NOT NULL,
    [ClassTypes_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ClassTypes'
ALTER TABLE [dbo].[ClassTypes]
ADD CONSTRAINT [PK_ClassTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Weapons'
ALTER TABLE [dbo].[Weapons]
ADD CONSTRAINT [PK_Weapons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Weapons_Id], [ClassTypes_Id] in table 'WeaponClassType'
ALTER TABLE [dbo].[WeaponClassType]
ADD CONSTRAINT [PK_WeaponClassType]
    PRIMARY KEY CLUSTERED ([Weapons_Id], [ClassTypes_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Weapons_Id] in table 'WeaponClassType'
ALTER TABLE [dbo].[WeaponClassType]
ADD CONSTRAINT [FK_WeaponClassType_Weapon]
    FOREIGN KEY ([Weapons_Id])
    REFERENCES [dbo].[Weapons]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ClassTypes_Id] in table 'WeaponClassType'
ALTER TABLE [dbo].[WeaponClassType]
ADD CONSTRAINT [FK_WeaponClassType_ClassType]
    FOREIGN KEY ([ClassTypes_Id])
    REFERENCES [dbo].[ClassTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WeaponClassType_ClassType'
CREATE INDEX [IX_FK_WeaponClassType_ClassType]
ON [dbo].[WeaponClassType]
    ([ClassTypes_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------