using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class OrderController : Controller
    {
        List<Order> orderList = new List<Order>
        {
            new Order
            {
                OrdereId = 100,
                Product = "Iphone",
                Amount =  500,
                CostomerId = 1,
                CreationDate = DateTime.Now,
                IsActive = true,
                IsDeleted = false
            },
            new Order
            {
                OrdereId = 100,
                Product = "car",
                Amount =  5000,
                CostomerId = 1,
                CreationDate = DateTime.Now,
                IsActive = true,
                IsDeleted = false
            },

            new Order
            {
                OrdereId = 100,
                Product = "table",
                Amount =  50,
                CostomerId = 2,
                CreationDate = DateTime.Now,
                IsActive = true,
                IsDeleted = false
            }
            };
        
        public IActionResult CustmerOrders(int ? id)
        {
            if( id == null) { return RedirectToAction("GetAllCustomers", "Customers"); }
            var data = (from x in orderList
                        where x.CostomerId == id
                        select x
                        );
            
            return View(data);
        }


        public IActionResult AllOrders()
        {
            return View(orderList);
        }
    }
}
