SET @DATAAJUSTE = '2020-03-11';
SET @CODEMPRESA = 1;
SET @CODDEPARTAMENTO = 3; 
SET @CODPRODUTO = 449;
 
 SELECT AJ.CODEMPRESA, AJ.CODDEPARTAMENTO, DATE_FORMAT(AJ.DATAAJUSTE,'%d/%m/%Y') AS DATAAJUSTE,
 AJ.CODPRODUTO, P.NOME AS NOMEPRODUTO, AJ.QUANTIDADE, AJ.MOTIVO  
 FROM ajuste_estoque AJ
 INNER JOIN produtos P ON AJ.CODPRODUTO = P.CODPRODUTO  
 WHERE AJ.CODEMPRESA = @CODEMPRESA  
 AND AJ.CODDEPARTAMENTO = @CODDEPARTAMENTO  
 AND AJ.CODPRODUTO = @CODPRODUTO
 