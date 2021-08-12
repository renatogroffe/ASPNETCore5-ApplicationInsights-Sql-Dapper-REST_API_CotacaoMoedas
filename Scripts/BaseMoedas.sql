CREATE DATABASE BaseMoedas
GO

USE BaseMoedas
GO

CREATE TABLE dbo.Cotacoes(
	Sigla char(3) NOT NULL,
	NomeMoeda varchar(30) NOT NULL,
	UltimaCotacao datetime NOT NULL,
	Valor NUMERIC (18,4) NOT NULL,
	CONSTRAINT PK_Cotacoes PRIMARY KEY (Sigla)
)
GO


INSERT INTO dbo.Cotacoes
           (Sigla
           ,NomeMoeda
           ,UltimaCotacao
           ,Valor)
     VALUES
           ('USD'
           ,'Dólar norte-americano'
           ,'08/11/2021'
           ,5.221)

INSERT INTO dbo.Cotacoes
           (Sigla
           ,NomeMoeda
           ,UltimaCotacao
           ,Valor)
     VALUES
           ('EUR'
           ,'Euro'
           ,'08/11/2021'
           ,6.130)

INSERT INTO dbo.Cotacoes
           (Sigla
           ,NomeMoeda
           ,UltimaCotacao
           ,Valor)
     VALUES
           ('LIB'
           ,'Libra esterlina'
           ,'08/11/2021'
           ,7.240)
