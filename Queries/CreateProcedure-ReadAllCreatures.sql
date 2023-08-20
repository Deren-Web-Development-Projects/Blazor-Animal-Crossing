
CREATE PROCEDURE [dbo].[spCreatures_ReadAll]

AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		[Id]
		,[Name]
		,[Icon]
		,[SellPrice]
		,[ShadowSize]
		,[NorthTimeStart]
		,[NorthTimeEnd]
		,[SouthTimeStart]
		,[SouthTimeEnd]
		,[NorthMonthStart]
		,[NorthMonthEnd]
		,[SouthMonthStart]
		,[SouthMonthEnd]
  FROM [ACNHDatabase].[dbo].[CreatureData]
END
