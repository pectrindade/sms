SET @CODUNIDADE = 1;
SET @DATAPEDIDO = '2020-02-28';

SELECT P.NUMEROPEDIDO, P.CODUNIDADE, U.NOME AS NOMEUNIDADE, P.SOLICITANTE,  DATE_FORMAT(P.DATAPEDIDO, '%d/%m/%Y') AS DATAPEDIDO, P.`STATUS`, P.APROVADO
FROM pedido P 
INNER JOIN unidade U ON U.CODUNIDADE = P.CODUNIDADE
WHERE P.CODUNIDADE = @CODUNIDADE

ORDER BY P.DATAPEDIDO 