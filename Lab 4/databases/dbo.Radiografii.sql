CREATE TABLE [dbo].[Radiografii]
(
	[Id] INT IDENTITY (1,1) PRIMARY KEY, 
    [CNP] NCHAR(13) NOT NULL FOREIGN KEY REFERENCES Pacienti(CNP), 
    [Imagine] VARCHAR(100) NOT NULL, 
    [Data] DATETIME NOT NULL, 
    [Diagnostic] VARCHAR(100) NOT NULL, 
    [Comentarii] VARCHAR(255) NULL
)
