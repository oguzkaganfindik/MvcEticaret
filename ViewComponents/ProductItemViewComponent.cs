using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;

namespace MvcEticaret.ViewComponents
{
    public class ProductItemViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title, int startCount, decimal oldPrice, decimal price, string imageUrl, bool isSale)
        {
            var model = new ProductItemViewModel
            {
                Title = title,
                StartCount = startCount,
                OldPrice = oldPrice,
                Price = price,
                ImageUrl = imageUrl,
                IsSale = isSale
            };

            return View("Default", model);
        }
    }
}
