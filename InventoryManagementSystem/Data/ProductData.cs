using InventoryManagementSystem.Models;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem.Data;

// Loads and saves products in the products table
public class ProductData
{
    public List<Product> GetAll()
    {
        List<Product> products = new List<Product>();

        // Join so each product also gets its category name
        string sql = "SELECT p.product_id, p.product_code, p.product_name, p.category_id, c.category_name, " +
                     "p.unit_price, p.quantity, p.min_stock_level " +
                     "FROM products p INNER JOIN categories c ON p.category_id = c.category_id " +
                     "ORDER BY p.product_name";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    products.Add(ReadProduct(reader));
                }
            }
        }
        return products;
    }

    // Products where the quantity is at or below the minimum level
    public List<Product> GetLowStock()
    {
        List<Product> products = new List<Product>();

        string sql = "SELECT p.product_id, p.product_code, p.product_name, p.category_id, c.category_name, " +
                     "p.unit_price, p.quantity, p.min_stock_level " +
                     "FROM products p INNER JOIN categories c ON p.category_id = c.category_id " +
                     "WHERE p.quantity <= p.min_stock_level " +
                     "ORDER BY p.quantity, p.product_name";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    products.Add(ReadProduct(reader));
                }
            }
        }
        return products;
    }

    // Finds products where the name, code or category name contains the search text
    public List<Product> Search(string text)
    {
        List<Product> products = new List<Product>();

        string sql = "SELECT p.product_id, p.product_code, p.product_name, p.category_id, c.category_name, " +
                     "p.unit_price, p.quantity, p.min_stock_level " +
                     "FROM products p INNER JOIN categories c ON p.category_id = c.category_id " +
                     "WHERE p.product_name LIKE @text OR p.product_code LIKE @text OR c.category_name LIKE @text " +
                     "ORDER BY p.product_name";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                // % on both sides so the text can be anywhere in the value
                cmd.Parameters.AddWithValue("@text", "%" + text.Trim() + "%");

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(ReadProduct(reader));
                    }
                }
            }
        }
        return products;
    }

    public void Add(Product product)
    {
        string sql = "INSERT INTO products (product_code, product_name, category_id, unit_price, quantity, min_stock_level) " +
                     "VALUES (@code, @name, @categoryId, @price, @quantity, @minLevel)";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                AddParameters(cmd, product);
                cmd.ExecuteNonQuery();

                // Store the new id back in the object
                product.Id = (int)cmd.LastInsertedId;
            }
        }
    }

    public void Update(Product product)
    {
        string sql = "UPDATE products SET product_code = @code, product_name = @name, category_id = @categoryId, " +
                     "unit_price = @price, quantity = @quantity, min_stock_level = @minLevel " +
                     "WHERE product_id = @id";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                AddParameters(cmd, product);
                cmd.Parameters.AddWithValue("@id", product.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Stock movements for this product are removed too (ON DELETE CASCADE)
    public void Delete(int productId)
    {
        string sql = "DELETE FROM products WHERE product_id = @id";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", productId);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Checks if another product already uses this code (pass 0 when adding a new product)
    public bool CodeExists(string code, int excludeId)
    {
        string sql = "SELECT COUNT(*) FROM products WHERE product_code = @code AND product_id <> @id";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@code", code.Trim());
                cmd.Parameters.AddWithValue("@id", excludeId);
                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }

    // Adds the change to the quantity (negative change takes stock away), used inside a transaction
    public void ChangeQuantity(int productId, int change, MySqlConnection conn, MySqlTransaction transaction)
    {
        string sql = "UPDATE products SET quantity = quantity + @change WHERE product_id = @id";

        using (MySqlCommand cmd = new MySqlCommand(sql, conn, transaction))
        {
            cmd.Parameters.AddWithValue("@change", change);
            cmd.Parameters.AddWithValue("@id", productId);
            int rows = cmd.ExecuteNonQuery();

            if (rows == 0)
            {
                throw new Exception("Product was not found. It may have been deleted.");
            }
        }
    }

    // Gets the current quantity and locks the row until the transaction ends
    public int GetQuantity(int productId, MySqlConnection conn, MySqlTransaction transaction)
    {
        string sql = "SELECT quantity FROM products WHERE product_id = @id FOR UPDATE";

        using (MySqlCommand cmd = new MySqlCommand(sql, conn, transaction))
        {
            cmd.Parameters.AddWithValue("@id", productId);
            object result = cmd.ExecuteScalar();

            if (result == null)
            {
                throw new Exception("Product was not found. It may have been deleted.");
            }
            return Convert.ToInt32(result);
        }
    }

    // Same parameters are used by Add and Update
    private void AddParameters(MySqlCommand cmd, Product product)
    {
        cmd.Parameters.AddWithValue("@code", product.Code.Trim());
        cmd.Parameters.AddWithValue("@name", product.Name.Trim());
        cmd.Parameters.AddWithValue("@categoryId", product.CategoryId);
        cmd.Parameters.AddWithValue("@price", product.UnitPrice);
        cmd.Parameters.AddWithValue("@quantity", product.Quantity);
        cmd.Parameters.AddWithValue("@minLevel", product.MinStockLevel);
    }

    // Turns the current row of the reader into a Product object
    private Product ReadProduct(MySqlDataReader reader)
    {
        Product product = new Product();
        product.Id = reader.GetInt32("product_id");
        product.Code = reader.GetString("product_code");
        product.Name = reader.GetString("product_name");
        product.CategoryId = reader.GetInt32("category_id");
        product.CategoryName = reader.GetString("category_name");
        product.UnitPrice = reader.GetDecimal("unit_price");
        product.Quantity = reader.GetInt32("quantity");
        product.MinStockLevel = reader.GetInt32("min_stock_level");
        return product;
    }
}
