using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class DBHelper
    {
        ProductDbContext _db;
        public DBHelper(ProductDbContext db)
        {
            _db = db;
        }

        public List<Product> GetProducts()
        {
            return _db.Products.ToList();
        }

        public Product GetProductByID(int id)
        {
            return _db.Products.First(x => x.ProductID == id);
        }

        public void InsertProduct(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }

        public void EditProduct(Product newProduct)
        {
            _db.Products.Update(newProduct);
            _db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product product = GetProductByID(id);
            _db.Products.Remove(product);
            _db.SaveChanges();
        }
    }
}
