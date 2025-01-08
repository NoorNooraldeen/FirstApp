using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace FirstApp.Controllers
{
    public class CustomerController : Controller
    {


        //list of cos

        static List<Customer> coustmerList = new List<Customer>
        {
            new Customer {
           CustomereId = 1,
          CustomereName ="Noor",
            Email = " Noor@hotmail.com",
            phone ="99739488",
            CreationDate = DateTime.Now,
            IsActive = true,
            IsDeleted = false
        },

            new Customer {
            CustomereId = 2,
            CustomereName ="Sara",
            Email = " Sara@hotmail.com",
           phone ="97522215",
            CreationDate = DateTime.Now,
            IsActive = true,
            IsDeleted = false
             }

        };

        public IActionResult GetAllCoustmers()
        {
            return View(coustmerList.OrderBy(x => x.CustomereId));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("GetAllCoustmers");
            }
            var data = (from x in coustmerList
                        where x.CustomereId == id
                        select x).SingleOrDefault();
            if (data == null)
            {
                return RedirectToAction("GetAllCoustmers");
            }
            return View(data);

        }
        [HttpGet]
        public IActionResult Create() { return View(); }

        [HttpPost]
        public IActionResult Create( Customer c)
        {
            coustmerList.Add(c);
            return RedirectToAction(nameof(GetAllCoustmers));


        }

        public IActionResult ActiveCustomer()
        {

            var data = (from x in coustmerList
                        where x.IsActive == true
                        select x);
            return View(data);

           
        }

        public IActionResult NonActive()
        {

                var data = (from x in coustmerList
                            where x.IsActive == false
                            select x);
                return View(data);
        }

    }
}








