using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCAjaxify.Data;
using MVCAjaxify.Models;
using Newtonsoft.Json;

namespace MVCAjaxify.Controllers
{
    public class OrdersController : Controller
    {
        private readonly MVCAjaxifyDbContext _db;
        public OrdersController(MVCAjaxifyDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Customer> OrderAndCustomerList = _db.Customer.Include(o => o.Orders).ToList();
            return View(OrderAndCustomerList);
        }

        public ActionResult SaveOrder([FromBody]Model model)
        
        {
          

            string result = "Error! Order Is Not Complete!";
            if (model.name != null && model.address != null && model.order != null)
            {
                //var cutomerId = Guid.NewGuid();
                Customer customermodel = new Customer();
                //model.CustomerId = cutomerId;
                customermodel.Name = model.name;
                customermodel.Address = model.address;
                customermodel.OrderDate = DateTime.Now;
                _db.Customer.Add(customermodel);

                foreach (var item in model.order)
                {
                    //var orderId = Guid.NewGuid();
                    Orders O = new Orders();
                    //O.OrderId = orderId;
                    O.ProductName = item.ProductName;
                    O.Quantity = item.Quantity;
                    O.Price = item.Price;
                    O.Amount = item.Amount;
                    O.CustomerId = customermodel.CustomerId;
                    _db.Orders.Add(O);
                }
                _db.SaveChanges();
                result = "Success! Order Is Complete!";
            }
            return Json(result
                //, JsonRequestBehavior.AllowGet
                );
        }



        public class Model {
            public string name { get; set; }
            public string address { get; set; }
            public Orders[] order { get; set; }

        }

    }
}