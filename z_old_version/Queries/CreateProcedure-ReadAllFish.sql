
CREATE PROCEDURE [dbo].[spFish_ReadAll]

AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		[Id]
		,[Name]
		,[Icon]
		,[SellPrice]
		,[ShadowSize]
		,[Location]
		,[NorthTimeStart]
		,[NorthTimeEnd]
		,[SouthTimeStart]
		,[SouthTimeEnd]
		,[NorthMonthStart]
		,[NorthMonthEnd]
		,[SouthMonthStart]
		,[SouthMonthEnd]
  FROM [ACNHDatabase].[dbo].[FishData]
END
