-- Inventory Management System database
-- Run this in phpMyAdmin (SQL tab) or the MySQL command line

CREATE DATABASE IF NOT EXISTS inventory_db;
USE inventory_db;

-- Product categories, e.g. Drinks, Snacks
CREATE TABLE IF NOT EXISTS categories (
    category_id   INT AUTO_INCREMENT PRIMARY KEY,
    category_name VARCHAR(50) NOT NULL UNIQUE,
    description   VARCHAR(200) NULL
);

-- Products sold in the shop
CREATE TABLE IF NOT EXISTS products (
    product_id      INT AUTO_INCREMENT PRIMARY KEY,
    product_code    VARCHAR(20) NOT NULL UNIQUE,
    product_name    VARCHAR(100) NOT NULL,
    category_id     INT NOT NULL,
    unit_price      DECIMAL(10,2) NOT NULL DEFAULT 0,
    quantity        INT NOT NULL DEFAULT 0,
    min_stock_level INT NOT NULL DEFAULT 0,
    created_at      DATETIME DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_products_category FOREIGN KEY (category_id)
        REFERENCES categories (category_id) ON DELETE RESTRICT,
    CONSTRAINT chk_products_quantity CHECK (quantity >= 0),
    CONSTRAINT chk_products_min CHECK (min_stock_level >= 0),
    CONSTRAINT chk_products_price CHECK (unit_price >= 0)
);

-- Every stock change (IN = delivery, OUT = sold or removed)
CREATE TABLE IF NOT EXISTS stock_movements (
    movement_id   INT AUTO_INCREMENT PRIMARY KEY,
    product_id    INT NOT NULL,
    movement_type VARCHAR(3) NOT NULL,
    quantity      INT NOT NULL,
    note          VARCHAR(200) NULL,
    movement_date DATETIME DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_movements_product FOREIGN KEY (product_id)
        REFERENCES products (product_id) ON DELETE CASCADE,
    CONSTRAINT chk_movements_type CHECK (movement_type IN ('IN', 'OUT')),
    CONSTRAINT chk_movements_quantity CHECK (quantity > 0)
);
