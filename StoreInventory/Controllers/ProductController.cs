using StoreInventory.Models.Data;
using StoreInventory.Models.ViewModel;
using StoreInventory.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace StoreInventory.Controllers
{

    public class ProductController : Controller
    {
        private readonly IProductServices _productServices;

        public ProductController()
        {

        }
    
        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        // GET: Product
        [HttpGet]
        public ActionResult Index()
        {
            List<ProductDetailsViewModel> inventoryViewDetails = 
                _productServices.getProducts();            
            return View(inventoryViewDetails);
        }

        //GET: Product/Purchase/Id
        [HttpGet]
        public ActionResult Purchase(int Id)
        {
            ProductDetailsViewModel productVM = _productServices.getProducts(Id);
            return View(productVM);
        }

        //POST: Product/Purchase
        [HttpPost]
        public ActionResult Purchase(ProductDetailsViewModel purchasedItem)
        {            
            //Check ModelState
            if (!ModelState.IsValid)
            {
                return View(purchasedItem);
            }

            decimal userCharge = _productServices.purchaseProducts(purchasedItem);

            if(userCharge != 0) {
                return RedirectToAction("AddUser", "UserDetails", new { purchaseAmount = userCharge });
            }
            else
            {
                TempData["Purchased"] = "Provided Quantity is unavailable";
                return View(purchasedItem);
            }             
            
        }
    }
}