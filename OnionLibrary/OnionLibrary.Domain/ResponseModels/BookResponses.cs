namespace OnionLibrary.Domain.ResponseModels
{
    public class BookResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string BookDescription { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public bool IsRentable { get; set; }
        public string Rating { get; set; } = string.Empty;
    }
}
