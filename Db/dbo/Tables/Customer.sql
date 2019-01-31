CREATE TABLE [dbo].[Customer] (
    [CustomerId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (100) NULL,
    [Dni]        INT            NULL,
    [BirthDate]  DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

