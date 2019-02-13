CREATE TABLE [dbo].[Piece] (
    [PieceId]  INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (100) NULL,
    [Cost]     INT            NULL,
    [Quantity] INT            NULL,
    PRIMARY KEY CLUSTERED ([PieceId] ASC)
);

