using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcNorthwind.Bll.Concrete;
using AspNetMvcNorthwind.Dal.Concrete.EntityFramework;
using AspNetMvcNorthwind.Entities;

namespace AspNetMvcNorthwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ProductManager _productManager = new ProductManager(new EfProductDal());
        public ViewResult Index()
        {
            List<Product> products = _productManager.GetAll();
            return View(products);
        }

        
    }
}