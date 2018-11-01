SELECT FTSkuActiveAct AS Cmd,FTSkuCode AS Message_No,FTStandardCert AS Name,60 AS LabelWidth,
0 AS Font1,'YNNNNNN' AS FontType1,FTStandardCert AS Line1
FROM TCNMSKU 
WHERE FTSkuActiveAct IN ('A','D','U')
AND FTSkuWeightSta IN ('W','F')
AND DATALENGTH(TCNMSKU.FTSkuCode)= 6