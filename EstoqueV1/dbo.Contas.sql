CREATE TABLE [dbo].[Contas] (
    [Id]    INT          IDENTITY (0, 1) NOT NULL,
    [Login] VARCHAR (50) NOT NULL,
    [Senha] VARCHAR (50) NOT NULL,
    [Email] VARCHAR (50) NOT NULL,
    [Função] VARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC) 
);

