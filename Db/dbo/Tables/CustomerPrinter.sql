CREATE TABLE [dbo].[CustomerPrinter] (
    [CustomerId]        INT NULL,
    [PrinterId]         INT NULL,
    [CustomerPrinterId] INT IDENTITY (1, 1) NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerPrinterId] ASC),
    CONSTRAINT [FK_CustomerPrinter_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([CustomerId]),
    CONSTRAINT [FK_CustomerPrinter_PrinterId] FOREIGN KEY ([PrinterId]) REFERENCES [dbo].[Printer] ([PrinterId])
);



