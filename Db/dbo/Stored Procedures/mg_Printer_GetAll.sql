-- =============================================
-- Author:		Gaston Arechavala
-- Create date: 12/4/2018
-- Description:	
-- =============================================
CREATE PROCEDURE mg_Printer_GetAll 
 
AS
BEGIN
	select PrinterId,Serial,Mark,Model,CopiesCounter
	from Printer
END