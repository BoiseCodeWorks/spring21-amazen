CREATE TABLE IF NOT EXISTS products(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'Product Name',
  description varchar(255) COMMENT 'Product Description',
  sku varchar(255) COMMENT 'Product SKU',
  price DECIMAL(6, 2) COMMENT 'Product Cost USD'
) default charset utf8 COMMENT '';
CREATE TABLE IF NOT EXISTS warehouses(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  location varchar(255) COMMENT 'Warehouse Name and location'
) default charset utf8 COMMENT '';
INSERT INTO
  warehouses (location)
VALUES
  ("Warehouse 1 - Pensacola Florida");
INSERT INTO
  warehouses (location)
VALUES
  ("Warehouse 2 - Boise Idaho");
INSERT INTO
  products (name, description, sku, price)
VALUES
  (
    "Etch-A-Sketch",
    "The Magic Screen, Unplug with this classic. No charging. No cords. No screen. Etch A Sketch is powered by your imagination. Mysteriously captivating fun for all ages. You won't be able to put it down.",
    "6033752",
    14.99
  );
INSERT INTO
  products (name, description, sku, price)
VALUES
  (
    "Teddy Ruxpin",
    "The original animated story telling toy. Join Teddy in his many adventures through the Worlds of Wonder.",
    "2543789",
    99.99
  );
CREATE TABLE IF NOT EXISTS warehouse_products(
    id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
    warehouseId int NOT NULL COMMENT 'FK: Warehouse Relationship',
    productId int NOT NULL COMMENT 'FK: Product Relationship',
    FOREIGN KEY (warehouseId) REFERENCES warehouses(id) ON DELETE CASCADE,
    FOREIGN KEY (productId) REFERENCES products(id) ON DELETE CASCADE
  );
INSERT INTO
  warehouse_products (warehouseId, productId)
VALUES
  (1, 2);
INSERT INTO
  warehouse_products (warehouseId, productId)
VALUES
  (2, 1);
SELECT
  p.*,
  w.location,
  wp.id as warehouseProductId,
  wp.productId as productId,
  wp.warehouseId as warehouseId
FROM
  warehouse_products wp
  JOIN warehouses w ON w.id = wp.warehouseId
  JOIN products p ON p.id = wp.productId
WHERE
  wp.warehouseId = 2;
-- one to one marriage
  -- person1 marriedTo person2.id
  -- person2 marriedTo person1.id
  -- one to many kids
  -- person1
  -- person2 parent person1.id
  -- person3 parent person1.id
  -- many to many toys
  -- person1
  -- person2
  -- kidstody toy.id person1.id
  -- kidstody toy.id person2.id