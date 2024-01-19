SELECT 
    P.ProductName AS '��� ��������',
    COALESCE(C.CategoryName, '��� ���������') AS '��� ���������'
FROM 
    Products P
LEFT JOIN 
    ProductCategory PC ON P.ProductID = PC.ProductID
LEFT JOIN 
    Categories C ON PC.CategoryID = C.CategoryID;