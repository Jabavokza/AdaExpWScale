SELECT FTSkuActiveAct,TCNMSKU.FTSkuCode,FTSkuWeightSta,FCSkuRegPrice,FTShelfLife,FTPbcBarcode,FTStandardCert,FTSkuDepCode 
FROM TCNMSKU,TCNMSKUBarcode 
WHERE FTSkuActiveAct  IN ('A','D','U') 
AND FTSkuWeightSta IN ('W','F')
AND TCNMSKU.FTSkuCode = TCNMSKUBarcode.FTSkuCode
