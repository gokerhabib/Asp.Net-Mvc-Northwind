using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcNorthwind.Bll.Concrete;
using AspNetMvcNorthwind.Dal.Concrete.EntityFramework;
using AspNetMvcNorthwind.Entities;
using AspNetMvcNorthwind.Interfaces;

namespace AspNetMvcNorthwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        //ProductManager _productManager = new ProductManager(new EfProductDal());
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ViewResult Index()
        {
            List<Product> products = _productService.GetAll();
            return View(products);
        }

        
    }
}