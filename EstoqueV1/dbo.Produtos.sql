CREATE TABLE [dbo].[Produtos] (
    [IdProduto]    INT          IDENTITY (0, 1) NOT NULL,
    [Nome]         VARCHAR (50) DEFAULT (NULL) NOT NULL,    
    [Categoria]    VARCHAR (50) DEFAULT (NULL) NOT NULL,
	[Fornecedor]   VARCHAR (50) NULL,
	[Estoque]      VARCHAR (50) NULL,
	[Quantidade]   INT          DEFAULT (NULL) NULL,
    [DataEntrada]  DATE         DEFAULT (NULL) NULL,
    [DataValidade] DATE         DEFAULT (NULL) NULL,
    [Valor]        FLOAT        NULL,
	[Responsável]  VARCHAR (50) NULL,
    [QtdMinima]    INT          NULL,
    [QtdMaxima]    INT          NULL,    
    PRIMARY KEY CLUSTERED ([IdProduto] ASC),    
);

