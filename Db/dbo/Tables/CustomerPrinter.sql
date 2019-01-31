CREATE TABLE [dbo].[CustomerPrinter] (
    [CustomerId] INT NULL,
    [PrinterId]  INT NULL,
    CONSTRAINT [FK_CustomerPrinter_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([CustomerId]),
    CONSTRAINT [FK_CustomerPrinter_PrinterId] FOREIGN KEY ([PrinterId]) REFERENCES [dbo].[Printer] ([PrinterId])
);

