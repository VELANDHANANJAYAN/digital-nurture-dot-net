SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS Rank,
    DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRank
FROM Products;
