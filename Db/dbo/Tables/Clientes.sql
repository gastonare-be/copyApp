CREATE TABLE [dbo].[Clientes] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [FechaNacimiento] DATETIME       NULL,
    [Nombre]          NVARCHAR (MAX) NULL,
    [Apellido]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

