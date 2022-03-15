USE [p2610018]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblStock_SelectAll]

SELECT	@return_value as 'Return Value'

GO
