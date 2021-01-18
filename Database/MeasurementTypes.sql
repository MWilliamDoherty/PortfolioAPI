CREATE TABLE [dbo].[MeasurementTypes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Type] NVARCHAR(50) NULL, 
    [UnitOfMeasure] BIT NULL, 
    [Name] NVARCHAR(50) NULL
)
