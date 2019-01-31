CREATE TABLE [dbo].[Maquinas] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [contador]  INT            NULL,
    [marca]     NVARCHAR (MAX) NULL,
    [modelo]    NVARCHAR (MAX) NULL,
    [serial]    INT            NULL,
    [ClienteId] INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Clientes] ([Id])
);

