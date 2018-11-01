SELECT FTSkuActiveAct AS Cmd, FTSkuCode AS Plu_No,FCSkuRegPrice AS UnitPrice FROM TCNMSKU 
WHERE FTSkuActiveAct IN ('A','D','U')
AND FTSkuWeightSta IN ('W','F')
AND DATALENGTH(TCNMSKU.FTSkuCode)<= 6