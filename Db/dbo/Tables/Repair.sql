CREATE TABLE [dbo].[Repair] (
    [RepairId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (100) NULL,
    [Cost]     INT            NULL,
    PRIMARY KEY CLUSTERED ([RepairId] ASC)
);

