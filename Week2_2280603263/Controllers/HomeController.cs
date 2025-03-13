using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Week2_2280603263.Models;
using Week2_2280603263.Repositories;

namespace Week2_2280603263.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public HomeController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop Asus",
                Description = "Laptop Asus Vivobook Go 15 E1504FA R5 7520U (NJ776W)", Price = 12190000 },

                new Product { Id = 2, Name = "Laptop HP",
                Description = "Laptop HP 15 fc0085AU R5 7430U (A6VV8PA)", Price = 13490000 },

                new Product { Id = 3, Name = "Laptop Dell ",
                Description = "Laptop Dell Inspiron 15 3520 i5 1235U (N5I5057W1)", Price = 16490000 },

                new Product { Id = 4, Name = "Laptop Lenovo",
                Description = "Laptop Lenovo Ideapad Slim 3 15AMN8 R5 7520U (82XQ00J0VN)", Price = 13190000 },

                new Product { Id = 5, Name = "Laptop Acer Nitro",
                Description = "Laptop Acer Nitro V 15 ANV15 41 R2UP R5 6600H (NH.QPGSV.004)", Price = 19490000 },

                new Product { Id = 6, Name = "Laptop MSI",
                Description = "Laptop MSI Gaming Thin 15 B12UCX i5 12450H (2046VN)", Price = 16190000 },

                new Product { Id = 7, Name = "Laptop MacBook",
                Description = "Laptop MacBook Air 13 inch M1 (MGN63SA/A)", Price = 17490000 },
            };

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
