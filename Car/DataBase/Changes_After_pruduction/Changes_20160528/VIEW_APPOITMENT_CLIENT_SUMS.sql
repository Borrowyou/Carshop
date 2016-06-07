IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[VIEW_APPOITMENT_CLIENT_SUMS]') AND OBJECTPROPERTY(id, N'IsView') = 1)
	BEGIN
		PRINT 'Dropping View VIEW_APPOITMENT_CLIENT_SUMS'
    DROP VIEW [dbo].VIEW_APPOITMENT_CLIENT_SUMS
  END
GO

PRINT 'Creating View VIEW_APPOITMENT_CLIENT_SUMS'
GO
CREATE VIEW VIEW_APPOITMENT_CLIENT_SUMS
AS
	SELECT  SW.APPOITMENT_ID, SW.SERVICE_WORK_ID, S.SERVICE_NAME, '' AS PART_NAME, '' AS PART_MANUF, SW.QUANTITY * SW.WORK_PRICE AS WORK_PRICE, SW.QUANTITY AS QUANTITY,
		SW.WORK_PRICE AS SINGLE_PRICE
	FROM SERVICE_WORKS SW
	INNER JOIN SERVICES S ON (S.SERVICE_ID = SW.SERVICE_ID)
	UNION ALL
	SELECT SW.APPOITMENT_ID, SWP.SERVICE_WORK_ID, '', P.part_name, P.part_manuf, ISNULL(SWP.PART_PRICE, P.part_price) * SWP.QUANTITY, SWP.QUANTITY, SWP.PART_PRICE AS SINGLE_PRICE
	FROM SERVICE_WORKS SW
	INNER JOIN SERVICE_WORK_PARTS SWP ON (SW.SERVICE_WORK_ID = SWP.SERVICE_WORK_ID)
	INNER JOIN PARTS P ON (SWP.PART_ID = P.PART_ID)
	
GO
   