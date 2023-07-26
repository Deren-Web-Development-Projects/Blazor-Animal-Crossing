CREATE TABLE [dbo].[Creatures]
(
  [Id] INT NOT NULL PRIMARY KEY,
  [Name] VARCHAR(50) NOT NULL,
  [Image] VARCHAR(100) NOT NULL,
  [Price] INT NOT NULL,
  [ShadowSize] VARCHAR(15) NOT NULL,
  [SwimmingPattern] VARCHAR(50) NOT NULL,
  [TimeStart] INT NOT NULL,
  [TimeEnd] INT NOT NULL,
  [MonthFirst] VARCHAR(3) NOT NULL,
  [MonthLast] VARCHAR(3) NOT NULL,
  [Hemisphere] VARCHAR(5) NOT NULL
)
