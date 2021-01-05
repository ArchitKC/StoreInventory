using StoreInventory.Models.ViewModel;
using StoreInventory.Services.Interfaces;
using System.Web.Mvc;

namespace StoreInventory.Controllers
{
    public class UserDetailsController : Controller
    {
        private readonly IUserDetailsServices _userDetailsServices;
        public UserDetailsController()
        {

        }

        public UserDetailsController(IUserDetailsServices userDetailsServices)
        {
            _userDetailsServices = userDetailsServices;
        }
        public ActionResult AddUser(decimal purchaseAmount)
        {
            TempData["Charge"] = "Total Charged is: " + purchaseAmount;
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult AddUser(UserDetailsViewModel userDetailsViewModel,decimal purchaseAmount)
        {
            decimal finalCharge = _userDetailsServices.UserDetailsAdd(userDetailsViewModel, purchaseAmount);
            TempData["Charge"] = "Total Amount Charged for you item is " + purchaseAmount;
            return View();
        }
    }
}