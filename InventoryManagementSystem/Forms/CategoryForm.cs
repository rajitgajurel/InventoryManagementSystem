using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Validation;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem.Forms
{
    public partial class CategoryForm : Form
    {
        private CategoryData categoryData = new CategoryData();

        // Id of the category picked in the grid, 0 means nothing selected
        private int selectedId = 0;

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                List<Category> categories = categoryData.GetAll();
                dgvCategories.DataSource = null;
                dgvCategories.DataSource = categories;

                // Nicer column headings and widths
                dgvCategories.Columns["Id"].HeaderText = "ID";
                dgvCategories.Columns["Id"].FillWeight = 15;
                dgvCategories.Columns["Name"].HeaderText = "Category Name";
                dgvCategories.Columns["Name"].FillWeight = 35;
                dgvCategories.Columns["Description"].FillWeight = 50;
                dgvCategories.ClearSelection();

                lblCount.Text = "Total categories: " + categories.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load categories.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Puts the clicked row into the text boxes
        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Category category = (Category)dgvCategories.Rows[e.RowIndex].DataBoundItem;
            selectedId = category.Id;
            txtName.Text = category.Name;
            txtDescription.Text = category.Description;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = txtName.Text.Trim();
            category.Description = txtDescription.Text.Trim();

            try
            {
                category.Validate();
                categoryData.Add(category);
                MessageBox.Show("Category added.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadCategories();
            }
            catch (MySqlException ex)
            {
                ShowDatabaseError(ex);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Check Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a category from the list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Category category = new Category();
            category.Id = selectedId;
            category.Name = txtName.Text.Trim();
            category.Description = txtDescription.Text.Trim();

            try
            {
                category.Validate();
                categoryData.Update(category);
                MessageBox.Show("Category updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadCategories();
            }
            catch (MySqlException ex)
            {
                ShowDatabaseError(ex);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Check Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a category from the list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Categories that still have products can't be deleted
                if (categoryData.HasProducts(selectedId))
                {
                    MessageBox.Show("This category still has products. Move or delete those products first.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult answer = MessageBox.Show("Delete category '" + txtName.Text + "'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    categoryData.Delete(selectedId);
                    ClearInputs();
                    LoadCategories();
                }
            }
            catch (MySqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            selectedId = 0;
            txtName.Clear();
            txtDescription.Clear();
            dgvCategories.ClearSelection();
            txtName.Focus();
        }

        private void ShowDatabaseError(MySqlException ex)
        {
            // 1062 = duplicate value in a UNIQUE column
            if (ex.Number == 1062)
            {
                MessageBox.Show("A category with this name already exists.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Database error.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
