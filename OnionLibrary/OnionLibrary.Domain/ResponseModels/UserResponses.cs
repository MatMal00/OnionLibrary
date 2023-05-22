using OnionLibrary.Domain.DBModels;

namespace OnionLibrary.Domain.ResponseModels
{
    public class UserSimplifiedResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public virtual Role? Role { get; set; }
    }
}
