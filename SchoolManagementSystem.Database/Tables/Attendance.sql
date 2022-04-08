﻿CREATE TABLE [dbo].[Attendance]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IsPresent] BIT NOT NULL, 
    [Date] DATE NOT NULL, 
    [StudentId] INT NULL, 
    [ClassId] INT NULL,
    CONSTRAINT [FK_Att_Student] FOREIGN KEY ([StudentId]) REFERENCES [Users]([Id]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Att_Class] FOREIGN KEY ([ClassId]) REFERENCES [Classes]([Id]) ON DELETE CASCADE ON UPDATE CASCADE
)
