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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        DataService<Order> orderDataService = new DataService<Order>();
        DataService<Customer> customerDataService = new DataService<Customer>();
        private Guid SelectId()
        {
            var id = dgwOrder.Rows[dgwOrder.SelectedCells[0].RowIndex].Cells["Id"].Value;
            lblOrderId.Text = id.ToString();
            return (Guid)id;

        }
        private void Clean()
        {
            txtOrderDescription.Text = string.Empty;
            nudOrderTotalPrice.Value = 0;
            GetCustomer();
        }

        private void ResetTable()
        {
            dgwOrder.DataSource = null;

            var orders = orderDataService.GetAll();
            List<OrderListVm> list = new List<OrderListVm>();

            foreach (var order in orders)
            {
                OrderListVm orderListVM = new OrderListVm()
                {
                    Id = order.Id,
                    No = order.No,
                    Description = order.Description,
                    TotalPrice = "$ " + order.TotalPrice.ToString(),
                    CustomerId = order.CustomerId,
                    CustomerName = customerDataService.GetAll().FirstOrDefault(x => x.Id == order.CustomerId).Name
                };
                list.Add(orderListVM);
            }
            dgwOrder.DataSource = list;
            dgwOrder.Columns["Id"].Visible = false;
            dgwOrder.Columns["CustomerId"].Visible = false;
            Clean();
        }
        private void GetCustomer()
        {
            cbCustomer.DataSource = null;
            cbCustomer.DataSource = customerDataService.GetAll();
            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "Id";
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            btnOrderUpdate.Enabled = false;
            ResetTable();
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                No = Guid.NewGuid(),
                Description = txtOrderDescription.Text,
                TotalPrice = Convert.ToDouble(nudOrderTotalPrice.Value),
                CustomerId = (Guid)cbCustomer.SelectedValue
            };
            orderDataService.Add(order);
            var result = orderDataService.GetAll();

            ResetTable();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deletingOrder = orderDataService.Get(SelectId());
            var deletedresul = orderDataService.Delete(deletingOrder);
            if (deletedresul)
            {
                MessageBox.Show("Silme işlemi başarılı");
            }
            else
            {
                MessageBox.Show("Silme işlemi Başarısız");
            }
            ResetTable();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var updatingOrder = orderDataService.Get(SelectId());
            txtOrderDescription.Text = updatingOrder.Description;
            nudOrderTotalPrice.Value = Convert.ToDecimal(updatingOrder.TotalPrice);
            cbCustomer.SelectedItem = customerDataService.Get(updatingOrder.CustomerId);
            btnOrderUpdate.Enabled = true;
            lblOrderId.Text = updatingOrder.Id.ToString();
        }

        private void btnOrderUpdate_Click(object sender, EventArgs e)
        {
            var updatedOrder = orderDataService.Get(Guid.Parse(lblOrderId.Text));
            updatedOrder.TotalPrice = Convert.ToDouble(nudOrderTotalPrice.Value);
            updatedOrder.CustomerId = (Guid)cbCustomer.SelectedValue;
            updatedOrder.Description = txtOrderDescription.Text;
            orderDataService.Update(updatedOrder);
            ResetTable();
            btnOrderUpdate.Enabled = false;
        }
    }
}
