using InventoryManagementSystem.Models;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem.Data;

// Loads and saves categories in the categories table
public class CategoryData
{
    public List<Category> GetAll()
    {
        List<Category> categories = new List<Category>();
        string sql = "SELECT category_id, category_name, description FROM categories ORDER BY category_name";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Category category = new Category();
                    category.Id = reader.GetInt32("category_id");
                    category.Name = reader.GetString("category_name");

                    // Description is optional so it can be NULL
                    if (reader.IsDBNull(reader.GetOrdinal("description")))
                    {
                        category.Description = "";
                    }
                    else
                    {
                        category.Description = reader.GetString("description");
                    }

                    categories.Add(category);
                }
            }
        }
        return categories;
    }

    public void Add(Category category)
    {
        string sql = "INSERT INTO categories (category_name, description) VALUES (@name, @description)";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@name", category.Name.Trim());
                cmd.Parameters.AddWithValue("@description", category.Description.Trim());
                cmd.ExecuteNonQuery();

                // Store the new id back in the object
                category.Id = (int)cmd.LastInsertedId;
            }
        }
    }

    public void Update(Category category)
    {
        string sql = "UPDATE categories SET category_name = @name, description = @description WHERE category_id = @id";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@name", category.Name.Trim());
                cmd.Parameters.AddWithValue("@description", category.Description.Trim());
                cmd.Parameters.AddWithValue("@id", category.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Delete(int categoryId)
    {
        string sql = "DELETE FROM categories WHERE category_id = @id";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", categoryId);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Used before deleting, because the database won't allow deleting a category that has products
    public bool HasProducts(int categoryId)
    {
        string sql = "SELECT COUNT(*) FROM products WHERE category_id = @id";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", categoryId);
                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
