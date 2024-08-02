using CustomerPortal.API.Models.Entities;

namespace CustomerPortal.API.Data
{
    public class DbInitializer
    {
        public static void Initializer(CustomerDBContext customerDBContext)
        {
            if (customerDBContext.Customers.Any()) { return; }

            var customers = new List<Customer>
            {
                new Customer
                {
                    FirstName="Nuwan Dilina",
                    LastName="Hettiarachchi",
                    Email="hnuwandilina@gmail.com",
                    Phone="07907773666",
                    Address="WS11 1JP",
                    CustomerType="Credit"
                },
                new Customer
                {
                    FirstName = "Samantha",
                    LastName = "Perera",
                    Email = "samantha.perera@example.com",
                    Phone = "07801234567",
                    Address = "SW1A 1AA",
                    CustomerType = "Debit"
                },
                new Customer
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Email = "john.smith@example.com",
                    Phone = "07709876543",
                    Address = "EC1A 1BB",
                    CustomerType = "Credit"
                },
                new Customer
                {
                    FirstName = "Emma",
                    LastName = "Johnson",
                    Email = "emma.johnson@example.com",
                    Phone = "07501234567",
                    Address = "W1A 1AB",
                    CustomerType = "Credit"
                },
                new Customer
                {
                    FirstName = "Ayesha",
                    LastName = "Fernando",
                    Email = "ayesha.fernando@example.com",
                    Phone = "07911223344",
                    Address = "M1 1AE",
                    CustomerType = "Debit"
                },
                new Customer
                {
                    FirstName = "Michael",
                    LastName = "Brown",
                    Email = "michael.brown@example.com",
                    Phone = "07455667788",
                    Address = "B1 1AB",
                    CustomerType = "Credit"
                },
                new Customer
                {
                    FirstName = "Sophia",
                    LastName = "Williams",
                    Email = "sophia.williams@example.com",
                    Phone = "07333445566",
                    Address = "C1 1CD",
                    CustomerType = "Debit"
                },
                new Customer
                {
                    FirstName = "James",
                    LastName = "Taylor",
                    Email = "james.taylor@example.com",
                    Phone = "07222334455",
                    Address = "L1 1XY",
                    CustomerType = "Credit"
                },
                new Customer
                {
                    FirstName = "Olivia",
                    LastName = "Davies",
                    Email = "olivia.davies@example.com",
                    Phone = "07111223344",
                    Address = "N1 1ZZ",
                    CustomerType = "Debit"
                },
                new Customer
                {
                    FirstName = "Liam",
                    LastName = "Wilson",
                    Email = "liam.wilson@example.com",
                    Phone = "07099887766",
                    Address = "S1 1AA",
                    CustomerType = "Credit"
                },

            };

            foreach (var customer in customers)
            {
                customerDBContext.Add(customer);
            }

            customerDBContext.SaveChanges();
        }
    }
}
