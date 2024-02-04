CREATE PROCEDURE dbo.ConsultaVeiculo 
(@AnCdVeiculo DECIMAL(10,0)
)
AS
BEGIN 
  SELECT nCdVeiculo
       , cNmVeiculo
	   , cNmMarca
	   , nPreco
	   , cNmLocadora
	   , cEndereco
    FROM Veiculo
   WHERE nCdVeiculo = @AnCdVeiculo
END