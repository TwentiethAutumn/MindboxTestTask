SELECT 
    Products.ProductName,
    ISNULL(Categories.CategoryName, 'No category') AS CategoryName
FROM 
    Products
LEFT JOIN 
    ProductCategories ON Products.ProductID = ProductCategories.ProductID
LEFT JOIN 
    Categories ON ProductCategories.CategoryID = Categories.CategoryID
ORDER BY 
    Products.ProductName, Categories.CategoryName;