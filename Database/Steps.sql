CREATE TABLE [dbo].[Steps]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [NumberInList] INT NULL, 
    [ActionId] INT NULL, 
    [Notes] NVARCHAR(MAX) NULL,
    [RecipeId] INT NULL, 
    FOREIGN KEY ([RecipeId]) REFERENCES [dbo].[Recipes](Id),
    FOREIGN KEY ([ActionId]) REFERENCES [dbo].[Actions](Id)
)
