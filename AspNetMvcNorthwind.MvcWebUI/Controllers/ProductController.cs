using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcNorthwind.Bll.Concrete;
using AspNetMvcNorthwind.Dal.Concrete.EntityFramework;
using AspNetMvcNorthwind.Entities;
using AspNetMvcNorthwind.Interfaces;
using AspNetMvcNorthwind.MvcWebUI.Models;

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

        public int pageSize = 5;
        public ViewResult Index(int category=0,int page = 1)
        {
            List<Product> products = _productService.GetAll().Where(a=>category == 0 ||a.CategoryID==category).ToList();


            return View(new ProductViewModel
                            {
                                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                                PagingInfo = new PagingInfo
                                {
                                    ItemsPerPage = pageSize,
                                    TotalItems = products.Count(),
                                    CurrentPage = page
                                },
                                CurrentCategory = category
            });
        }

        
    }
}