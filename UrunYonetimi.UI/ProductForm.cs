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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();

        }
        DataService<Product> productDataService = new DataService<Product>();
        DataService<Category> categoryDataService = new DataService<Category>();
        DataService<ProductCategory> productCategoryDataService = new DataService<ProductCategory>();

        private void ProductForm_Load(object sender, EventArgs e)
        {
            btnProductUpdate.Enabled = false;
            ResetTable();
        }
        private Guid SelectId()
        {
            var id = dgwProduct.Rows[dgwProduct.SelectedCells[0].RowIndex].Cells["Id"].Value;
            lblProductId.Text = id.ToString();
            return (Guid)id;

        }
        private void Clean()
        {
            txtProductName.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
            nudProductPrice.Value = 0;
        }

        private void ResetTable()
        {
            dgwProduct.DataSource = null;

            var products = productDataService.GetAll();
            List<ProductListVM> list = new List<ProductListVM>();

            foreach (var product in products)
            {
                var productCategories = productCategoryDataService.GetAll().Where(x => x.ProductId == product.Id);

                ProductListVM productListVM = new ProductListVM();

                productListVM.Id = product.Id;
                productListVM.Description = product.Description;
                productListVM.Name = product.Name;
                productListVM.Price = "$ " + product.Price.ToString();

                foreach (var productCategory in productCategories)
                {

                    productListVM.Categories = productListVM.Categories + " | " + categoryDataService.Get(productCategory.CategoryId).Name;
                }
                list.Add(productListVM);
            }
            dgwProduct.DataSource = list;
            dgwProduct.Columns["Id"].Visible = false;

            var categories = categoryDataService.GetAll();
            lbKategoriler.DataSource = null;
            lbKategoriler.DataSource = categories;
            lbKategoriler.DisplayMember = "Name";
            lbKategoriler.ValueMember = "Id";

            cbKategoriler.DataSource = null;
            cbKategoriler.DataSource = categories;
            cbKategoriler.DisplayMember = "Name";
            cbKategoriler.ValueMember = "Id";

            Clean();
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = txtProductName.Text,
                Description = txtProductDescription.Text,
                Price = Convert.ToDouble(nudProductPrice.Value)
            };
            productDataService.Add(product);

            var addedProduct = productDataService.GetAll().LastOrDefault();

            var selectedCategory = lbKategoriler.SelectedItems;

            foreach (Category category in selectedCategory)
            {
                ProductCategory productCategory = new ProductCategory();
                productCategory.ProductId = addedProduct.Id;
                productCategory.CategoryId = category.Id;
                productCategoryDataService.Add(productCategory);
            }

            ResetTable();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var updateProduct = productDataService.Get(SelectId());
            txtProductName.Text = updateProduct.Name;
            txtProductDescription.Text = updateProduct.Description;
            nudProductPrice.Value = Convert.ToDecimal(updateProduct.Price);
            btnProductUpdate.Enabled = true;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deletingProduct = productDataService.Get(SelectId());
            var result = productDataService.Delete(deletingProduct);
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

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {

                Name = txtProductName.Text,
                Description = txtProductDescription.Text,
                Price = Convert.ToDouble(nudProductPrice.Value),
                Id = Guid.Parse(lblProductId.Text)
            };
            productDataService.Update(product);
            btnProductUpdate.Enabled = false;
            ResetTable();
        }

        private void lbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productCategories = productCategoryDataService.GetAll().Where(x => x.CategoryId == Guid.Parse(cbKategoriler.SelectedValue.ToString()));
            List<Product> products = new List<Product>();

            foreach (var productCategory in productCategories)
            {
                var product = productDataService.GetAll().FirstOrDefault(x => x.Id == productCategory.ProductId);
                products.Add(product);
            }

            dgwProduct.DataSource = null;
            dgwProduct.DataSource = products;
        }
    }
}
