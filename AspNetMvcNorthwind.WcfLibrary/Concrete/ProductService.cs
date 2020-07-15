using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcNorthwind.Bll.Concrete;
using AspNetMvcNorthwind.Dal.Concrete.EntityFramework;
using AspNetMvcNorthwind.Entities;
using AspNetMvcNorthwind.Interfaces;

namespace AspNetMvcNorthwind.WcfLibrary.Concrete
{
    public class ProductService:IProductService
    {
        //Instance Provider ile ezilecek
        private ProductManager _productManager = new ProductManager(new EfProductDal());
        public List<Product> GetAll()
        {
            return _productManager.GetAll();
        }

        public Product Get(int productId)
        {
            return _productManager.Get(productId);
        }

        public void Delete(int productId)
        {
           _productManager.Delete(productId);
        }

        public void Update(Product product)
        {
            _productManager.Update(product);
        }

        public void Add(Product product)
        {
            _productManager.Add(product);
        }
    }
}
