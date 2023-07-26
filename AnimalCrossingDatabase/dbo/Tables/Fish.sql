CREATE TABLE [dbo].[Fish]
(
  [Id] INT NOT NULL PRIMARY KEY,
  [Name] VARCHAR(50) NOT NULL,
  [Image] VARCHAR(100) NOT NULL,
  [Price] INT NOT NULL,
  [Location] VARCHAR(10) NOT NULL,
  [TimeStart] INT NOT NULL,
  [TimeEnd] INT NOT NULL,
  [MonthFirst] VARCHAR(3) NOT NULL,
  [MonthLast] VARCHAR(3) NOT NULL,
  [Hemisphere] VARCHAR(5) NOT NULL
)
