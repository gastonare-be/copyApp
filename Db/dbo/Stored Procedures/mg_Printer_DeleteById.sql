-- =============================================
-- Author:		Gaston Arechavala
-- Create date: 01/30/2019
-- Description:	Delete a printer by Id
-- =============================================
CREATE PROCEDURE mg_Printer_DeleteById 
	-- Add the parameters for the stored procedure here
	@Id int = 0 
	
AS
BEGIN
	DELETE FROM Printer where PrinterId=@Id 
END