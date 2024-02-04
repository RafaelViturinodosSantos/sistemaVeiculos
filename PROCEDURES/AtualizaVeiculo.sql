CREATE PROCEDURE dbo.AtualizaVeiculo 
(@AnCdVeiculo    DECIMAL(10,0)
,@AcNomeVeiculo  VARCHAR(100)
,@AcNomeMarca    VARCHAR(100)
,@AnPreco        DECIMAL(16,2)
,@AcNomeLocadora VARCHAR(100)
,@AcNmEndereco   VARCHAR(100)
)
AS
BEGIN 

DROP TABLE IF EXISTS #tVeiculo

  CREATE TABLE #tVeiculo (nCdVeiculo  DECIMAL(10,0)
                         ,cNmVeiculo  VARCHAR(100)
                         ,cNmMarca    VARCHAR(100)
                         ,nPreco      DECIMAL(16,2)
                         ,cNmLocadora VARCHAR(100)
                         ,cEndereco   VARCHAR(100)
	                     ) 

  INSERT INTO #tVeiculo (nCdVeiculo
                        ,cNmVeiculo  
                        ,cNmMarca   
                        ,nPreco     
                        ,cNmLocadora 
                        ,cEndereco   
				 	    )
  SELECT @AnCdVeiculo    
       , @AcNomeVeiculo  
       , @AcNomeMarca    
       , @AnPreco        
       , @AcNomeLocadora 
       , @AcNmEndereco  


  --Verifica se cNmVeiculo foi alterado para atualizar
  IF EXISTS (SELECT 1 
               FROM Veiculo V
  	                INNER JOIN #tVeiculo T ON T.nCdVeiculo = V.nCdVeiculo
  			  WHERE V.cNmVeiculo <> T.cNmVeiculo
  		     )
	   BEGIN
  		  UPDATE Veiculo
  		     SET cNmVeiculo = T.cNmVeiculo
  			FROM Veiculo V
  	             INNER JOIN #tVeiculo T ON T.nCdVeiculo = V.nCdVeiculo
       END
  --Verifica se cNmMarca foi alterado para atualizar
  IF EXISTS (SELECT 1 
               FROM Veiculo V
  	                INNER JOIN #tVeiculo T ON T.nCdVeiculo = V.nCdVeiculo
  			  WHERE V.cNmMarca <> T.cNmMarca
  		    )
	  BEGIN
  		  UPDATE Veiculo
  		     SET cNmMarca = T.cNmMarca
  			FROM Veiculo V
  	             INNER JOIN #tVeiculo T ON T.nCdVeiculo = V.nCdVeiculo
      END
   
  --Verifica se nPreco foi alterado para atualizar
  IF EXISTS (SELECT 1 
               FROM Veiculo V
  	                INNER JOIN #tVeiculo T ON T.nCdVeiculo = V.nCdVeiculo
  			  WHERE V.nPreco <> T.nPreco
  		    )
	  BEGIN
  		  UPDATE Veiculo
  		     SET nPreco = T.nPreco
  			FROM Veiculo V
  	             INNER JOIN #tVeiculo T ON T.nCdVeiculo = V.nCdVeiculo
  	  END
		
  --Verifica se cNmLocadora foi alterado para atualizar
  IF EXISTS (SELECT 1 
               FROM Veiculo V
  	                INNER JOIN #tVeiculo T ON T.nCdVeiculo = V.nCdVeiculo
  			  WHERE V.cNmLocadora <> T.cNmLocadora
  		     )
      BEGIN
  		  UPDATE Veiculo
  		     SET cNmLocadora = T.cNmLocadora
  			FROM Veiculo V
  	             INNER JOIN #tVeiculo T ON T.nCdVeiculo = V.nCdVeiculo
       END

  --Verifica se cNmLocadora foi alterado para atualizar
  IF EXISTS (SELECT 1 
               FROM Veiculo V
  	                INNER JOIN #tVeiculo T ON T.nCdVeiculo = V.nCdVeiculo
  			  WHERE V.cEndereco <> T.cEndereco
  		     )
	  BEGIN
  		  UPDATE Veiculo
  		     SET cEndereco = T.cEndereco
  			FROM Veiculo V
  	             INNER JOIN #tVeiculo T ON T.nCdVeiculo = V.nCdVeiculo
      END

END