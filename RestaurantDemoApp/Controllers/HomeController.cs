using RestaurantDemoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantDemoApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CustomerRepository objCustomerRepository = new CustomerRepository();
            ItemRepository objItemRepository = new ItemRepository();
            PaymentRepositroy objPaymentRepositroy = new PaymentRepositroy();
           
            var objMultipleModels =                  
                new Tuple<IEnumerable<SelectListItem>,
                 IEnumerable<SelectListItem>, 
                 IEnumerable<SelectListItem>>(objCustomerRepository.GetAllCustomers(),
                 objItemRepository.GetAllItems(),
                 objPaymentRepositroy.GetAllPaymentType());
            
            
            return View(objMultipleModels);
        }
    }
}