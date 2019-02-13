CREATE TABLE [dbo].[RepairPiece] (
    [RepairPieceId] INT IDENTITY (1, 1) NOT NULL,
    [RepairId]      INT NULL,
    [PieceId]       INT NULL,
    [PieceQuantity] INT NULL,
    PRIMARY KEY CLUSTERED ([RepairPieceId] ASC),
    FOREIGN KEY ([PieceId]) REFERENCES [dbo].[Piece] ([PieceId]),
    FOREIGN KEY ([RepairId]) REFERENCES [dbo].[Repair] ([RepairId])
);

