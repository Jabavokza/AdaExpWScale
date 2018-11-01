SELECT FTSkuActiveAct,TCNMSKU.FTSkuCode,FTSkuWeightSta,FCSkuRegPrice,FTShelfLife,FTPbcBarcode,FTStandardCert,FTSkuDepCode 
FROM TCNMSKU,TCNMSKUBarcode 
WHERE FTSkuActiveAct  IN ('A','D','U') AND DATALENGTH(TCNMSKU.FTSkuCode) = 6 AND FTSkuWeightSta IN ('W','F')
