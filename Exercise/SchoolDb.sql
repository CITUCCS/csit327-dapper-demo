/*** Delete db if exist ***/
DROP DATABASE IF EXISTS [Exer1Db]
GO

/*** Create db ***/
CREATE DATABASE [Exer1Db]
GO

/*** Use DB ***/
USE [Exer1Db]
GO

/*** Drop Table ***/
DROP TABLE [dbo].[School]
GO

/*** Create school table ***/
CREATE TABLE [dbo].[School]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [Motto] NVARCHAR(50) NOT NULL, 
    [AverageTuition] DECIMAL(18,2) NOT NULL
)
GO

INSERT [dbo].[School] ([Name], [Address], [Motto], [AverageTuition]) 
VALUES ('CIT-U', 'N. Bacalso Ave, Cebu City', 'CCS IS THE BEST COLLEGE', 69.69);

INSERT [dbo].[School] ([Name], [Address], [Motto], [AverageTuition]) 
VALUES ('USC', 'Somewhere bukid, Cebu City', 'Daghan gwapa ug gwapo', 34.35);

INSERT [dbo].[School] ([Name], [Address], [Motto], [AverageTuition]) 
VALUES ('UC', 'Colon, Cebu City', 'wEbMasTerS', 5.00);

INSERT [dbo].[School] ([Name], [Address], [Motto], [AverageTuition]) 
VALUES ('USJR', 'Atbang Carbon, Cebu City', 'Pray lng jud ta', 25.69);