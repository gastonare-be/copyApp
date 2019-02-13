-- =============================================
-- Author:		Gaston Arechavala
-- Create date: 01/31/2019
-- Description:	Get All Customers
-- =============================================
CREATE PROCEDURE mg_Customer_GetAll 

AS
BEGIN
	SELECT c.CustomerId,
	c.Dni,
	c.[Name],
	c.BirthDate
	 from Customer c
END