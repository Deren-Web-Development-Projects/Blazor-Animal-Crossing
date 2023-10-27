
CREATE PROCEDURE [dbo].[spBugs_ReadAll]

AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		[Id]
		,[Name]
		,[Icon]
		,[SellPrice]
		,[Weather]
		,[Location]
		,[NorthTimeStart]
		,[NorthTimeEnd]
		,[SouthTimeStart]
		,[SouthTimeEnd]
		,[NorthMonthStart]
		,[NorthMonthEnd]
		,[SouthMonthStart]
		,[SouthMonthEnd]
  FROM [ACNHDatabase].[dbo].[BugData]
END
