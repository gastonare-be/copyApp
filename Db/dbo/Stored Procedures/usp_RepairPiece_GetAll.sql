-- =============================================
-- Author:		Gaston Arechavala
-- Create date: 02/11/2019
-- Description:	Get history of Repairs
-- =============================================
CREATE PROCEDURE usp_RepairPiece_GetAll 
	-- Add the parameters for the stored procedure here
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT r.Name as 'Repair Name', 
	 r.Cost as 'Repair Cost',
	 p.Name as 'Piece Name',
	 p.Cost as 'Piece Cost',
	 rp.PieceQuantity as 'Piece Quantity',
	  p.Cost * rp.PieceQuantity 'Total'
	   from RepairPiece rp 
	inner join Repair r on rp.RepairId = r.RepairId
	inner join Piece p on rp.PieceId = p.PieceId

END