using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        // Product Catalog
        public ActionResult Index()
        {
            return View();
        }

        // Product Details
        public ActionResult Details(int id)
        {
            if (id == 1)
            {
                ViewBag.ProductId = 1;
                ViewBag.ProductName = "Laptop";
                ViewBag.Description = "HP Laptop with 16GB RAM and 512GB SSD";
                ViewBag.Price = 80000;
            }
            else if (id == 2)
            {
                ViewBag.ProductId = 2;
                ViewBag.ProductName = "Mobile";
                ViewBag.Description = "Samsung Mobile with 8GB RAM and 128GB Storage";
                ViewBag.Price = 30000;
            }
            else if (id == 3)
            {
                ViewBag.ProductId = 3;
                ViewBag.ProductName = "Headphones";
                ViewBag.Description = "Wireless Headphones";
                ViewBag.Price = 5000;
            }

            return View();
        }
    }
}