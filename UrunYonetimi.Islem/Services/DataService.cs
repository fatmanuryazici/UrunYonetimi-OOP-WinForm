using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunYonetimi.Data;
using UrunYonetimi.Model.Models;

namespace UrunYonetimi.Islem.Services
{
    public class DataService<T> : IDataService<T> where T : BaseModel
    {
        public bool Add(T model)
        {
            model.CreatedDate = DateTime.Now;
            model.Id = Guid.NewGuid();
            model.Status = Model.Enums.Status.Create;
            if (model is Customer customer)
            {
                DataBase.Customers.Add(customer);
                return true;
            }
            else if (model is Product product)
            {
                DataBase.Products.Add(product);
                return true;
            }
            else if (model is Order order)
            {
                DataBase.Orders.Add(order);
                return true;
            }
            else if (model is Category category)
            {
                DataBase.Categories.Add(category);
                return true;
            }
            else if (model is ProductCategory productCategory)
            {
                DataBase.ProductsCategories.Add(productCategory);
                return true;
            }
            else if (model is OrderProduct orderProduct)
            {
                DataBase.OrdersProducts.Add(orderProduct);
                return true;
            }
            else { return false; }
        }

        public bool Delete(T model)
        {
            model.DeletedDate = DateTime.Now;
            model.Status = Model.Enums.Status.Delete;

            if (model is Customer customer)
            {
                var updateCustomer = DataBase.Customers.FirstOrDefault(x => x.Id == customer.Id);
                var index = DataBase.Customers.IndexOf(updateCustomer);
                DataBase.Customers[index] = customer;
                return true;
            }
            else if (model is Category category)
            {
                var updateCategory = DataBase.Categories.FirstOrDefault(x => x.Id == category.Id);
                var index = DataBase.Categories.IndexOf(updateCategory);
                DataBase.Categories[index] = category;
                return true;
            }
            else if (model is Order order)
            {
                var updateOrder = DataBase.Orders.FirstOrDefault(x => x.Id == order.Id);
                var index = DataBase.Orders.IndexOf(updateOrder);
                DataBase.Orders[index] = order;
                return true;
            }
            else if (model is Product product)
            {
                var updateProduct = DataBase.Products.FirstOrDefault(x => x.Id == product.Id);
                var index = DataBase.Products.IndexOf(updateProduct);
                DataBase.Products[index] = product;
                return true;
            }
            else if (model is OrderProduct orderProduct)
            {
                var updateOrderProduct = DataBase.OrdersProducts.FirstOrDefault(x => x.Id == orderProduct.Id);

                var index = DataBase.OrdersProducts.IndexOf(updateOrderProduct);
                DataBase.OrdersProducts[index] = orderProduct;
                return true;
            }
            else if (model is ProductCategory productCategory)
            {
                var updateProductCategory = DataBase.ProductsCategories.FirstOrDefault(x => x.Id == productCategory.Id);

                var index = DataBase.ProductsCategories.IndexOf(updateProductCategory);
                DataBase.ProductsCategories[index] = productCategory;
                return true;
            }
            else { return false; }
        }

        public T Get(Guid id)
        {
            if (typeof(T) == typeof(Customer))
            {
                return DataBase.Customers.OfType<T>().ToList().FirstOrDefault(x => x.Id == id && x.Status != Model.Enums.Status.Delete);
            }
            else if (typeof(T) == typeof(Product))
            {
                return DataBase.Products.OfType<T>().ToList().FirstOrDefault(x => x.Id == id && x.Status != Model.Enums.Status.Delete);
            }
            else if (typeof(T) == typeof(Category))
            {
                return DataBase.Categories.OfType<T>().ToList().FirstOrDefault(x => x.Id == id && x.Status != Model.Enums.Status.Delete);
            }
            else if (typeof(T) == typeof(Order))
            {
                return DataBase.Orders.OfType<T>().ToList().FirstOrDefault(x => x.Id == id && x.Status != Model.Enums.Status.Delete);
            }
            else if (typeof(T) == typeof(OrderProduct))
            {
                return DataBase.OrdersProducts.OfType<T>().ToList().FirstOrDefault(x => x.Id == id && x.Status != Model.Enums.Status.Delete);
            }
            else if (typeof(T) == typeof(ProductCategory))
            {
                return DataBase.ProductsCategories.OfType<T>().ToList().FirstOrDefault(x => x.Id == id && x.Status != Model.Enums.Status.Delete);
            }
            else
            {
                return null;
            }
        }

        public List<T> GetAll()
        {
            if (typeof(T) == typeof(Customer))
            {
                return DataBase.Customers.OfType<T>().Where(x => x.Status != Model.Enums.Status.Delete).ToList();
            }
            else if (typeof(T) == typeof(Product))
            {
                return DataBase.Products.OfType<T>().Where(x => x.Status != Model.Enums.Status.Delete).ToList();
            }
            else if (typeof(T) == typeof(Category))
            {
                return DataBase.Categories.OfType<T>().Where(x => x.Status != Model.Enums.Status.Delete).ToList();
            }
            else if (typeof(T) == typeof(Order))
            {
                return DataBase.Orders.OfType<T>().Where(x => x.Status != Model.Enums.Status.Delete).ToList();
            }
            else if (typeof(T) == typeof(OrderProduct))
            {
                return DataBase.OrdersProducts.OfType<T>().Where(x => x.Status != Model.Enums.Status.Delete).ToList();
            }
            else if (typeof(T) == typeof(ProductCategory))
            {
                return DataBase.ProductsCategories.OfType<T>().Where(x => x.Status != Model.Enums.Status.Delete).ToList();
            }
            else
            {
                return null;
            }
        }

        public bool Update(T model)
        {
            model.ModifiedDate = DateTime.Now;
            model.Status = Model.Enums.Status.Update;

            if (model is Customer customer)
            {
                var updateCustomer = DataBase.Customers.FirstOrDefault(x => x.Id == customer.Id);
                customer.CreatedDate = updateCustomer.CreatedDate;
                var index = DataBase.Customers.IndexOf(updateCustomer);
                DataBase.Customers[index] = customer;
                return true;
            }
            else if (model is Category category)
            {
                var updateCategory = DataBase.Categories.FirstOrDefault(x => x.Id == category.Id);

                category.CreatedDate = updateCategory.CreatedDate;
                var index = DataBase.Categories.IndexOf(updateCategory);
                DataBase.Categories[index] = category;
                return true;
            }
            else if (model is Order order)
            {
                var updateOrder = DataBase.Orders.FirstOrDefault(x => x.Id == order.Id);

                order.CreatedDate = updateOrder.CreatedDate;
                var index = DataBase.Orders.IndexOf(updateOrder);
                DataBase.Orders[index] = order;
                return true;
            }
            else if (model is Product product)
            {
                var updateProduct = DataBase.Products.FirstOrDefault(x => x.Id == product.Id);

                product.CreatedDate = updateProduct.CreatedDate;
                var index = DataBase.Products.IndexOf(updateProduct);
                DataBase.Products[index] = product;
                return true;
            }
            else if (model is OrderProduct orderProduct)
            {
                var updateOrderProduct = DataBase.OrdersProducts.FirstOrDefault(x => x.Id == orderProduct.Id);

                orderProduct.CreatedDate = updateOrderProduct.CreatedDate;
                var index = DataBase.OrdersProducts.IndexOf(updateOrderProduct);
                DataBase.OrdersProducts[index] = orderProduct;
                return true;
            }
            else if (model is ProductCategory productCategory)
            {
                var updateProductCategory = DataBase.ProductsCategories.FirstOrDefault(x => x.Id == productCategory.Id);
                productCategory.CreatedDate = updateProductCategory.CreatedDate;
                var index = DataBase.ProductsCategories.IndexOf(updateProductCategory);
                DataBase.ProductsCategories[index] = productCategory;
                return true;
            }
            else { return false; }
        }
    }
}
