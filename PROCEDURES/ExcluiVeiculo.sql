CREATE PROCEDURE dbo.ExcluiVeiculo 
(@AnCdVeiculo DECIMAL(10,0)
)
AS
BEGIN 
  DELETE 
    FROM Veiculo 
   WHERE nCdVeiculo = @AnCdVeiculo
END