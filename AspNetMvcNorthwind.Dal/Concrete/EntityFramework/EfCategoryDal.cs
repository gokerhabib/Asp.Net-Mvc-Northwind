using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcNorthwind.Dal.Abstract;
using AspNetMvcNorthwind.Entities;

namespace AspNetMvcNorthwind.Dal.Concrete.EntityFramework
{
    public class EfCategoryDal :ICategoryDal
    {
        NorthwindContext _context = new NorthwindContext();
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category Get(int categoryId)
        {
           return _context.Categories.FirstOrDefault(a => a.CategoryID == categoryId);
        }
    }
}
