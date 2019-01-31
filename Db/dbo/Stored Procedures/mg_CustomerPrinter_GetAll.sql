-- =============================================
-- Author:		Gaston Arechavala
-- Create date: 12/11/2018
-- Description:	Get all customer with printers
-- =============================================
CREATE PROCEDURE [dbo].[mg_CustomerPrinter_GetAll] 
	 
AS
BEGIN
	Select c.CustomerId,c.Name,c.Dni,p.PrinterId,p.Mark,p.Model,p.Serial from CustomerPrinter cp
	INNER JOIN Customer c on cp.CustomerId=c.CustomerId
	INNER JOIN Printer p on cp.PrinterId=p.PrinterId
END