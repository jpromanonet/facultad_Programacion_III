 DECLARE @Fecha DateTime = CAST('2010/21/12' AS DateTime)
SELECT  CAST(CAST((GETDATE()-@FECHA) AS INT)/30 AS INT)