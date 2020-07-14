using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcNorthwind.Entities;

namespace AspNetMvcNorthwind.Dal.Abstract
{
    public interface IProductDal
    {
        List<Product> GetALL();

        Product Get(int productId);

        void Add(Product product);
        void Delete(int productId);
        void Update(int productId);

    }
}
