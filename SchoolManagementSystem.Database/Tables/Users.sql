﻿CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [UserName] NVARCHAR(24) UNIQUE NOT NULL, 
    [Password] NVARCHAR(24) NOT NULL, 
    [Role] NvarCHAR(10) NOT NULL,
    [Fee] decimal(18,2) NOT NULL DEFAULT 0,
    [ParentId] INT NULL
)
