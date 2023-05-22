using OnionLibrary.Domain.DBModels;

namespace OnionLibrary.Domain.ResponseModels
{
    public class FilledCategoryResponse
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public virtual ICollection<Book>? Books { get; set; }
    }
}
