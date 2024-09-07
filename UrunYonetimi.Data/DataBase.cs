using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunYonetimi.Model.Models;

namespace UrunYonetimi.Data
{
    public static class DataBase
    {
        public static List<Product> Products { get; set; } = new List<Product>();
        public static List<Category> Categories { get; set; } = new List<Category>();
        public static List<Customer> Customers { get; set; } = new List<Customer>();
        public static List<Order> Orders { get; set; } = new List<Order>();
        public static List<ProductCategory> ProductsCategories { get; set; } = new List<ProductCategory>();
        public static List<OrderProduct> OrdersProducts { get; set; } = new List<OrderProduct>();

    }
}
