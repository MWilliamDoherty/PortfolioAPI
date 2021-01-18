CREATE TABLE [dbo].[MeasurementForStep]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [StepID] INT NULL, 
    [MeasurementId] INT NULL,
    FOREIGN KEY ([StepID]) REFERENCES [dbo].[Steps]([Id]),
    FOREIGN KEY ([MeasurementId]) REFERENCES [dbo].[Measurements]([Id])
)
