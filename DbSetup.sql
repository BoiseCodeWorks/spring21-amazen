CREATE TABLE IF NOT EXISTS products(
  id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) comment 'Product Name',
  description varchar(255) comment 'Product Description',
  sku varchar(255) comment 'Product SKU',
  price DECIMAL(6, 2) comment 'Product Cost USD'
) default charset utf8 comment '';
CREATE TABLE IF NOT EXISTS warehouses(
  id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  location varchar(255) comment 'Warehouse Name and location'
) default charset utf8 comment '';
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
  )