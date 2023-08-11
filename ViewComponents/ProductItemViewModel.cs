namespace MvcEticaret.ViewComponents
{
    public class ProductItemViewModel
    {
        public string Title { get; set; }
        public int StartCount { get; set; }
        public decimal OldPrice { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsSale { get; set; }
    }
}