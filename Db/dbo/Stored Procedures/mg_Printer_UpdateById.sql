-- =============================================
-- Author:		Gaston Arechavala
-- Create date: 01/30/2019
-- Description:	Update a printer by Id
-- =============================================
CREATE PROCEDURE mg_Printer_UpdateById 
	-- Add the parameters for the stored procedure here
	@Id int,
	@serial nvarchar(100) = '', 
	@mark nvarchar(100) = '',
	@model int,
	@copiesCounter int
AS
BEGIN
	UPDATE Printer 
	SET Serial=@serial, Mark=@mark, Model=@model, CopiesCounter=@copiesCounter
	Where PrinterId=@Id
END