using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcNorthwind.Dal.Abstract;
using AspNetMvcNorthwind.Entities;

namespace AspNetMvcNorthwind.Dal.Concrete.EntityFramework
{
    public class EfProductDal:IProductDal
    {
        private  NorthwindContext _context = new NorthwindContext();
        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product Get(int productId)
        {
            return _context.Products.FirstOrDefault(a => a.ProductID == productId);

        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int productId)
        {
            _context.Products.Remove(_context.Products.FirstOrDefault(a => a.ProductID == productId));
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _context.Products.FirstOrDefault(a => a.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            _context.SaveChanges();
        }
    }
}
