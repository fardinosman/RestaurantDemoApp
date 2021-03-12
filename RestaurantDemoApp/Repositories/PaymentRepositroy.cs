using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantDemoApp.Models;
namespace RestaurantDemoApp.Repositories
{
    public class PaymentRepositroy
    {
        RestaurantDBEntities objRestaurantDbEntities;
        public PaymentRepositroy()
        {
            objRestaurantDbEntities = new RestaurantDBEntities();
        }
        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
          var objSelectListItems =
                new List<SelectListItem>();

            objSelectListItems = (from obj in objRestaurantDbEntities.PaymentTypes
                                  select new SelectListItem()
                                  {
                                      Text = obj.PaymentType,
                                      Value = obj.PaymentTypeId.ToString(),
                                      Selected = true
                                  }).ToList();

            return objSelectListItems;
        }
    }
}