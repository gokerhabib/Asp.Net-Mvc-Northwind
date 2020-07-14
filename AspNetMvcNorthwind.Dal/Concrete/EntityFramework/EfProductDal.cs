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
        public List<Product> GetALL()
        {
            throw new NotImplementedException();
        }

        public Product Get(int productId)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public void Update(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
