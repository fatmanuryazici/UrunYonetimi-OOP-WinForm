using UrunYonetimi.Islem.Services;
using UrunYonetimi.Model.Models;

namespace UrunYonetimi.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataService<Category> categoryDataService = new DataService<Category>();
            DataService<Product> productDataService = new DataService<Product>();
            DataService<Customer> customerDataService = new DataService<Customer>();
            categoryDataService.Add(new Category { Name = "Elektronik" });
            categoryDataService.Add(new Category { Name = "Gýda ve Ýçecek" });
            categoryDataService.Add(new Category { Name = "Saðlýk ve Güzellik" });
            categoryDataService.Add(new Category { Name = "Spor ve Outdoor" });
            productDataService.Add(new Product { Name = "Akýllý telefonlar", Description = "IOS ve Android Telefonlar", Price = 25000 });
            productDataService.Add(new Product { Name = "Spor Ayakkabý", Description = "gore-tex", Price = 1500 });
            productDataService.Add(new Product { Name = "Kuruyemiþ", Description = "Karýþýk-Lüx", Price = 150 });
            productDataService.Add(new Product { Name = "Vitamin", Description = "A-D-E-K vitaminleri", Price = 1900 });
            customerDataService.Add(new Customer { Name = "Bilge Adam", Adress = "Noramin-Maslak", PhoneNumber = "444 0 245" });
            customerDataService.Add(new Customer { Name = "Þenol Ticaret A.Þ.", Adress = "Çorum", PhoneNumber = "444 0 225" });
            customerDataService.Add(new Customer { Name = "Herþey Sahte Ltd. Þti.", Adress = "Samanyolu-Uzay", PhoneNumber = "444 0 267" });
        }



        private void müþterilerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }

        private void sipariþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void msCustomer_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
