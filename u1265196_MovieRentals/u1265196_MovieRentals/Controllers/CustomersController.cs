using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u1265196_MovieRentals.Models;
using u1265196_AdWeb.DataAccess;

namespace u1265196_AdWeb.Controllers
{

    public class CustomersController : Controller
    {

        // GET: Employee/GetAllEmpDetails

        public ActionResult ViewCustomers()
        {

            CustomerDataAccess CustomerDA = new CustomerDataAccess();
            ModelState.Clear();
            return View(CustomerDA.GetAllCustomers());
        }

        // GET: Add Customers
        public ActionResult AddCustomer()
        {
            return View();
        }

        // POST: Add Customers
        [HttpPost]
        public ActionResult AddCustomer(Customers customers)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CustomerDataAccess CustomerDA = new CustomerDataAccess();

                    if (CustomerDA.AddCustomer(customers))
                    {
                        ViewBag.Message = "Customer details added successfully";
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

    

       




    }
}
