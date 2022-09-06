/*** Delete db if exist ***/
DROP DATABASE IF EXISTS [ValoDb]
GO

/*** Create db ***/
CREATE DATABASE [ValoDb]
GO

/*** Use DB ***/
USE [ValoDb]
GO

/*** Drop Table ***/
DROP TABLE IF EXISTS [dbo].[Agent]
GO

/*** Create Agent table ***/
CREATE TABLE [dbo].[Agent]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Country] NVARCHAR(50) NOT NULL, 
    [Role] NVARCHAR(50) NOT NULL
)
GO

INSERT [dbo].[Agent] ([Name], [Country], [Role]) 
VALUES ('Jett', 'Korea', 'Duelist');

INSERT [dbo].[Agent] ([Name], [Country], [Role]) 
VALUES ('Omen', 'Unknown', 'Controller');

INSERT [dbo].[Agent] ([Name], [Country], [Role]) 
VALUES ('Sova', 'Russia', 'Initiator');

INSERT [dbo].[Agent] ([Name], [Country], [Role]) 
VALUES ('Sage', 'China', 'Sentinel');

INSERT [dbo].[Agent] ([Name], [Country], [Role]) 
VALUES ('Neon', 'Philippines', 'Duelist');