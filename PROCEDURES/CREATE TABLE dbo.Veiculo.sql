USE [Matriz]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Veiculo](
	[nCdVeiculo] [int] IDENTITY(1,1) NOT NULL,
	[cNmVeiculo] [nvarchar](100) NOT NULL,
	[cNmMarca] [nvarchar](100) NOT NULL,
	[nPreco] [decimal](16,2) NULL,
	[cNmLocadora] [nvarchar](100) NULL,
	[cEndereco] [nvarchar](100) NULL,
	[dCadastroVeiculo] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nCdVeiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Veiculo] ADD  DEFAULT (getdate()) FOR [dCadastroVeiculo]
GO


