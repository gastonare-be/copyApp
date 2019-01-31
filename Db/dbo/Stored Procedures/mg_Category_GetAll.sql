-- =============================================
-- Author:		Gaston Arechavala
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[mg_Category_GetAll] 
	  
AS
BEGIN
	SELECT CategoryId,CategoryName from Category 
END