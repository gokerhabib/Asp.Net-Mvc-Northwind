using System.Web.Mvc;
using AspNetMvcNorthwind.Entities;
using AspNetMvcNorthwind.Interfaces;

namespace AspNetMvcNorthwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductService _productService;

        public CartController(IProductService productService)
        {
            _productService = productService;
        }

        public ViewResult Index()
        {
            var cart = (Cart) Session["cart"];
            return View(cart);
        }
        public RedirectToRouteResult AddToCart(int productId)
        {
            Product product = _productService.Get(productId);
            var cart = (Cart)Session["cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            cart.AddToCart(product,1);
            return RedirectToAction("Index",cart);

        }
        public RedirectToRouteResult RemoveFromCart(int productId)
        {
            Product product = _productService.Get(productId);
            var cart = (Cart) Session["cart"];
            if (cart.Lines.Count == 0)
            {
                ModelState.AddModelError("", "Sepette zaten ürün yok");
            }
            else
            {
                cart.RemoveFromCart(product);
            }
            return RedirectToAction("Index", cart);
        }
    }
}