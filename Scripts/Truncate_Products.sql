DELETE FROM products;
UPDATE SQLITE_SEQUENCE SET seq = 0 WHERE name = 'products';
VACUUM;