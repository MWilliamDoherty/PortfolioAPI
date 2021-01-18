CREATE TABLE [dbo].[Measurements]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [IngredientId] INT NULL, 
    [MeasurementTypeId] INT NULL, 
    [Quantity] DECIMAL NULL,
    FOREIGN KEY ([MeasurementTypeId]) REFERENCES [dbo].[MeasurementTypes](Id)
)
