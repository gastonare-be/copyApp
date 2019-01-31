CREATE TABLE [dbo].[Category] (
    [CategoryId]   INT            IDENTITY (1, 1) NOT NULL,
    [CategoryName] NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([CategoryId] ASC)
);

