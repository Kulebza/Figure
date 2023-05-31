SELECT p."name" , c."name"  FROM products p
LEFT JOIN product_categories ON p.id = product_categories.product_id  
LEFT JOIN categories c ON c.id = product_categories.category_id 
order by p."name" 