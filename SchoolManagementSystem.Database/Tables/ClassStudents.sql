﻿CREATE TABLE [dbo].[ClassStudents]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ClassId] INT NULL FOREIGN KEY REFERENCES [dbo].[Classes]([Id]) ON DELETE CASCADE ON UPDATE CASCADE,
    [StudentId] INT NULL FOREIGN KEY REFERENCES [dbo].[Users]([Id]) ON DELETE SET NULL ON UPDATE SET NULL
)
