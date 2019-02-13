CREATE TABLE [dbo].[Provider] (
    [ProviderId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (100) NOT NULL,
    [Address]    NVARCHAR (100) NULL,
    [Phone]      NVARCHAR (100) NULL,
    [Cuit]       NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([ProviderId] ASC),
    UNIQUE NONCLUSTERED ([Cuit] ASC)
);

