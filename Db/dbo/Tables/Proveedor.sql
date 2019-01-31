CREATE TABLE [dbo].[Proveedor] (
    [Nombre]    NVARCHAR (50) NULL,
    [Direccion] NVARCHAR (50) NULL,
    [Telefono]  NVARCHAR (50) NULL,
    [Cuit]      NVARCHAR (50) NULL,
    [ID]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

