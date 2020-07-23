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

        public ViewResult Index(Cart cart)
        {
            return View(cart);
        }
        public RedirectToRouteResult AddToCart(Cart cart,int productId)
        {
            Product product = _productService.Get(productId);

            cart.AddToCart(product,1);
            return RedirectToAction("Index",cart);

        }
        public RedirectToRouteResult RemoveFromCart(Cart cart,int productId)
        {
            Product product = _productService.Get(productId);

            cart.RemoveFromCart(product);

            return RedirectToAction("Index", cart);
        }

        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }
        [HttpPost]
        public ActionResult Checkout(ShippingDetails shippingDetails)
        {
            if (ModelState.IsValid)
            {
                //Managerdan veri tabanına kayıt sağlanacak

                return View("Completed");
            }
            else
            {
                return View(shippingDetails);
            }
        }

        public PartialViewResult SummaryCart(Cart cart)
        {
            return PartialView(cart);
        }
    }
}