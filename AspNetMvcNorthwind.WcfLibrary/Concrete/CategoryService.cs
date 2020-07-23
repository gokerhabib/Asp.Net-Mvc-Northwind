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
    public class CategoryService:ICategoryService
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        public List<Category> GetAll()
        {
            return _categoryManager.GetAll();
        }

        public Category Get(int categoryId)
        {
            return _categoryManager.Get(categoryId);
        }
    }
}
