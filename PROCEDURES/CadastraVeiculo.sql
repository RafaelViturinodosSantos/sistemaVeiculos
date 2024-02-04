CREATE PROCEDURE dbo.CadastraVeiculo 
(@AcNmVeiculo    VARCHAR(100)
,@AcNmMarca      VARCHAR(100)
,@AnPreco        DECIMAL(16,2)
,@AcNmLocadora   VARCHAR(100)
,@AcNmEndereco   VARCHAR(100)
)
AS
BEGIN 
  INSERT INTO dbo.Veiculo ( cNmVeiculo
                          , cNmMarca
						  , nPreco
						  , cNmLocadora
						  , cEndereco
						  , dCadastroVeiculo
						  ) 
                   VALUES ( @AcNmVeiculo 
                          , @AcNmMarca   
                          , @AnPreco       
                          , @AcNmLocadora
                          , @AcNmEndereco
						  , GETDATE()
						  )

END