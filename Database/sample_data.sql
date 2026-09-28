-- Sample data for testing the Inventory Management System
-- Run inventory_db.sql first, then run this script
-- Warning: this deletes all existing data in inventory_db

USE inventory_db;

DELETE FROM stock_movements;
DELETE FROM products;
DELETE FROM categories;
ALTER TABLE stock_movements AUTO_INCREMENT = 1;
ALTER TABLE products AUTO_INCREMENT = 1;
ALTER TABLE categories AUTO_INCREMENT = 1;

-- Categories
INSERT INTO categories (category_id, category_name, description) VALUES
(1, 'Drinks', 'Soft drinks, juice and water'),
(2, 'Snacks', 'Chips, biscuits and chocolate'),
(3, 'Dairy', 'Milk, cheese and yoghurt'),
(4, 'Bakery', 'Bread and cakes baked daily'),
(5, 'Household', 'Cleaning and paper products');

-- Products (some are at or below their min level so the low stock alerts can be tested)
INSERT INTO products (product_id, product_code, product_name, category_id, unit_price, quantity, min_stock_level) VALUES
(1, 'DRK001', 'Coca Cola 600ml', 1, 4.50, 48, 20),
(2, 'DRK002', 'Orange Juice 1L', 1, 5.20, 8, 10),
(3, 'DRK003', 'Spring Water 1.5L', 1, 2.80, 60, 24),
(4, 'SNK001', 'Potato Chips 175g', 2, 3.90, 35, 15),
(5, 'SNK002', 'Chocolate Bar 50g', 2, 2.50, 0, 20),
(6, 'SNK003', 'Choc Chip Biscuits', 2, 3.60, 12, 12),
(7, 'DRY001', 'Full Cream Milk 2L', 3, 3.80, 25, 10),
(8, 'DRY002', 'Cheddar Cheese 500g', 3, 8.90, 6, 5),
(9, 'DRY003', 'Greek Yoghurt 1kg', 3, 6.40, 3, 6),
(10, 'BAK001', 'White Bread Loaf', 4, 3.20, 18, 8),
(11, 'BAK002', 'Blueberry Muffins 4pk', 4, 5.50, 10, 4),
(12, 'HSE001', 'Dishwashing Liquid 500ml', 5, 4.20, 14, 5),
(13, 'HSE002', 'Paper Towels 2pk', 5, 3.70, 2, 6),
(14, 'HSE003', 'Laundry Powder 2kg', 5, 12.50, 9, 4);

-- Stock movement history (quantities above already include these)
INSERT INTO stock_movements (product_id, movement_type, quantity, note, movement_date) VALUES
(1, 'IN', 60, 'Delivery from supplier', '2026-09-20 09:15:00'),
(1, 'OUT', 12, 'Sold', '2026-09-22 17:30:00'),
(2, 'IN', 20, 'Delivery from supplier', '2026-09-20 09:20:00'),
(2, 'OUT', 12, 'Sold', '2026-09-24 16:45:00'),
(5, 'IN', 30, 'Delivery from supplier', '2026-09-21 10:00:00'),
(5, 'OUT', 30, 'Sold out', '2026-09-25 18:10:00'),
(7, 'IN', 30, 'Morning delivery', '2026-09-23 07:30:00'),
(7, 'OUT', 5, 'Sold', '2026-09-23 19:00:00'),
(9, 'IN', 10, 'Delivery from supplier', '2026-09-22 08:45:00'),
(9, 'OUT', 5, 'Sold', '2026-09-24 12:20:00'),
(9, 'OUT', 2, 'Damaged, thrown out', '2026-09-25 09:00:00'),
(10, 'IN', 20, 'Bakery delivery', '2026-09-26 06:30:00'),
(10, 'OUT', 2, 'Sold', '2026-09-26 11:15:00'),
(13, 'IN', 10, 'Delivery from supplier', '2026-09-21 14:00:00'),
(13, 'OUT', 8, 'Sold', '2026-09-25 15:40:00');
