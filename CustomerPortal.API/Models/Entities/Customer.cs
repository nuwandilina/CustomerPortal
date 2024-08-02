﻿namespace CustomerPortal.API.Models.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public string? Address { get; set; }
        public required string CustomerType { get; set; }
    }
}
