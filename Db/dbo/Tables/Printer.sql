CREATE TABLE [dbo].[Printer] (
    [PrinterId]     INT            IDENTITY (1, 1) NOT NULL,
    [Serial]        NVARCHAR (100) NULL,
    [Mark]          NVARCHAR (50)  NOT NULL,
    [Model]         NVARCHAR (50)  NOT NULL,
    [CopiesCounter] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([PrinterId] ASC)
);

