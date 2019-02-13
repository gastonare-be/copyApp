-- =============================================
-- Author:		Gaston Arechavala
-- Create date: 01/30/2019
-- Description:	Add a new printer
-- =============================================
CREATE PROCEDURE mg_Printer_Add 
	-- Add the parameters for the stored procedure here
	@serial nvarchar(100) = '', 
	@mark nvarchar(100) = '',
	@model int,
	@copiesCounter int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO Printer(Serial,Mark,Model,CopiesCounter)
	VALUES(@serial,@mark,@model,@copiesCounter)
END