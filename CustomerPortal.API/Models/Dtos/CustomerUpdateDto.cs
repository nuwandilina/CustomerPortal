namespace CustomerPortal.API.Models.Dtos
{
    public class CustomerUpdateDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public string? Address { get; set; }
    }
}
