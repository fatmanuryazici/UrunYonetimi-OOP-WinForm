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
    public partial class CustomerForm : Form
    {

        public CustomerForm()
        {
            InitializeComponent();
        }
        DataService<Customer> dataService = new DataService<Customer>();

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Name = txtCustomerName.Text,
                Adress = txtCustomerAdress.Text,
                PhoneNumber = txtCustomerPhoneNumber.Text
            };
            dataService.Add(customer);
            ResetTable();

        }

        private void ResetTable()
        {
            dgwCustomer.DataSource = null;

            var customers = dataService.GetAll();
            List<CustomerListVM> list = new List<CustomerListVM>();

            foreach (var customer in customers)
            {
                CustomerListVM customerListVM = new CustomerListVM()
                {
                    Id = customer.Id,
                    Adress = customer.Adress,
                    PhoneNumber = customer.PhoneNumber,
                    Name = customer.Name,
                    
                };
                list.Add(customerListVM);
            }
            dgwCustomer.DataSource = list;
            dgwCustomer.Columns["Id"].Visible = false;
            Clean();
        }

        private void Clean()
        {
            txtCustomerAdress.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtCustomerPhoneNumber.Text = string.Empty;
        }

        private Guid SelectId()
        {
            var id = dgwCustomer.Rows[dgwCustomer.SelectedCells[0].RowIndex].Cells["Id"].Value;
            lblCustomerId.Text = id.ToString();
            return (Guid)id;

        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deletingCustomer = dataService.Get(SelectId());
            var result = dataService.Delete(deletingCustomer);
            if (result)
            {
                MessageBox.Show("Silme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Hatalı Silme İşlemi");
            }
            ResetTable();

            var res = dataService.GetAll();
            var res2 = Data.DataBase.Customers;
        }


        private void CustomerForm_Load(object sender, EventArgs e)
        {
            btnCustomerUpdate.Enabled = false;
            ResetTable();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var updateCustomer = dataService.Get(SelectId());
            txtCustomerAdress.Text = updateCustomer.Adress;
            txtCustomerName.Text = updateCustomer.Name;
            txtCustomerPhoneNumber.Text = updateCustomer.PhoneNumber;
            btnCustomerUpdate.Enabled = true;
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Adress = txtCustomerAdress.Text,
                Name = txtCustomerName.Text,
                PhoneNumber = txtCustomerPhoneNumber.Text,
                Id = Guid.Parse(lblCustomerId.Text)
            };
            dataService.Update(customer);
            ResetTable();
        }
    }
}
