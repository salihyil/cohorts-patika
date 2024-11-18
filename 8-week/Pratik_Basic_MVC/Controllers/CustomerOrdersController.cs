using Microsoft.AspNetCore.Mvc;
using Pratik_Basic_MVC.Models;

namespace Pratik_Basic_MVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "salih",
                Lastname = "yilmaz",
                Email = "salih_yil@live.com",
            };

            List<Order> orders = [
                new() { Id = 1, Price = 2420.00m, ProductName = "Laptop", Quantity = 1 },
                new() { Id = 2, Price = 2502.00m, ProductName = "Tablet", Quantity = 2 },
                new() { Id = 3, Price = 3432.00m, ProductName = "Phone", Quantity = 2 },
                new() { Id = 4, Price = 500.00m, ProductName = "Watch", Quantity = 1 },
                new() { Id = 5, Price = 500.00m, ProductName = "Keyboard", Quantity = 1 },
                new() { Id = 6, Price = 500.00m, ProductName = "Mouse", Quantity = 1 }
            ];

            CustomerOrderViewModel customerOrderViewModel = new()
            {
                Customer = customer,
                Orders = orders
            };

            return View(customerOrderViewModel);
        }

    }

}

