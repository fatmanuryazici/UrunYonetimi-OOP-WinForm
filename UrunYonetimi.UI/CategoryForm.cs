using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunYonetimi.Islem.Services;
using UrunYonetimi.Model.Models;
using UrunYonetimi.UI.VMs;

namespace UrunYonetimi.UI
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        DataService<Category> dataService = new DataService<Category>();
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            btnCategoryUpdate.Enabled = false;
            ResetTable();
        }

        private Guid SelectId()
        {
            var id = dgwCategory.Rows[dgwCategory.SelectedCells[0].RowIndex].Cells["Id"].Value;
            lblCategoryId.Text = id.ToString();
            return (Guid)id;

        }
        private void Clean()
        {
            txtCategoryName.Text = string.Empty;
        }

        private void ResetTable()
        {
            dgwCategory.DataSource = null;

            var categories = dataService.GetAll();
            List<CategoryListVM> list = new List<CategoryListVM>();

            foreach (var category in categories)
            {
                CategoryListVM categoryListVM = new CategoryListVM()
                {
                    Id = category.Id,
                    Name = category.Name
                };
                list.Add(categoryListVM);
            }
            dgwCategory.DataSource = list;
            dgwCategory.Columns["Id"].Visible = false;
            Clean();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                Name = txtCategoryName.Text,
            };
            dataService.Add(category);
            ResetTable();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var updateCategory = dataService.Get(SelectId());
            txtCategoryName.Text = updateCategory.Name;
            btnCategoryUpdate.Enabled = true;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deletingCategory = dataService.Get(SelectId());
            var result = dataService.Delete(deletingCategory);
            if (result)
            {
                MessageBox.Show("Silme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Hatalı Silme İşlemi");
            }
            ResetTable();
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {

                Name = txtCategoryName.Text,
                Id = Guid.Parse(lblCategoryId.Text)
            };
            dataService.Update(category);
            btnCategoryUpdate.Enabled = false;
            ResetTable();
        }

        private void dgwCategory_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {                
                dgwCategory.ClearSelection();
                dgwCategory.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
