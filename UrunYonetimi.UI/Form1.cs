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
            categoryDataService.Add(new Category { Name = "G�da ve ��ecek" });
            categoryDataService.Add(new Category { Name = "Sa�l�k ve G�zellik" });
            categoryDataService.Add(new Category { Name = "Spor ve Outdoor" });
            productDataService.Add(new Product { Name = "Ak�ll� telefonlar", Description = "IOS ve Android Telefonlar", Price = 25000 });
            productDataService.Add(new Product { Name = "Spor Ayakkab�", Description = "gore-tex", Price = 1500 });
            productDataService.Add(new Product { Name = "Kuruyemi�", Description = "Kar���k-L�x", Price = 150 });
            productDataService.Add(new Product { Name = "Vitamin", Description = "A-D-E-K vitaminleri", Price = 1900 });
            customerDataService.Add(new Customer { Name = "Bilge Adam", Adress = "Noramin-Maslak", PhoneNumber = "444 0 245" });
            customerDataService.Add(new Customer { Name = "�enol Ticaret A.�.", Adress = "�orum", PhoneNumber = "444 0 225" });
            customerDataService.Add(new Customer { Name = "Her�ey Sahte Ltd. �ti.", Adress = "Samanyolu-Uzay", PhoneNumber = "444 0 267" });
        }



        private void m��terilerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void �r�nlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }

        private void sipari�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void msCustomer_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
