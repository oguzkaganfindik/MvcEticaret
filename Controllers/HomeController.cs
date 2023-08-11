using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using MvcEticaret.ViewComponents;
using System.Diagnostics;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = new List<ProductItemViewModel>
            {
                new ProductItemViewModel
                {
                    Title = "Fancy Product",
                    StartCount = 0,
                    OldPrice = 40.00m,
                    Price = 80.00m,
                    ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg",
                    IsSale = false
                },

                new ProductItemViewModel
                {
                    Title = "Special Item",
                    StartCount = 5,
                    OldPrice = 20.00m,
                    Price = 18.00m,
                    ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg",
                    IsSale = true
                },

                new ProductItemViewModel                
                {
                    Title = "Sale Item",
                    StartCount = 0,
                    OldPrice = 50.00m,
                    Price = 25.00m,
                    ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg",
                    IsSale = true
                },

                new ProductItemViewModel                
                {
                    Title = "Popular Item",
                    StartCount = 5,
                    OldPrice = 40.00m,
                    Price = 40.00m,
                    ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg",
                    IsSale = false
                },

                new ProductItemViewModel                
                {
                    Title = "Sale Item",
                    StartCount = 0,
                    OldPrice = 50.00m,
                    Price = 25.00m,
                    ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg",
                    IsSale = true
                },

                new ProductItemViewModel                
                {
                    Title = "Fancy Product",
                    StartCount = 0,
                    OldPrice = 120.00m,
                    Price = 280.00m,
                    ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg",
                    IsSale = false
                },

                new ProductItemViewModel                
                {
                    Title = "Special Item",
                    StartCount = 5,
                    OldPrice = 20.00m,
                    Price = 18.00m,
                    ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg",
                    IsSale = true
                },

                new ProductItemViewModel                
                {
                    Title = "Popular Item",
                    StartCount = 5,
                    OldPrice = 40.00m,
                    Price = 40.00m,
                    ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg",
                    IsSale = false
                },
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