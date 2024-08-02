using CustomerPortal.API.Data;
using CustomerPortal.API.Models.Dtos;
using CustomerPortal.API.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerDBContext dBContext;

        public CustomerController(CustomerDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var allCustomers = dBContext.Customers.ToList();
            return Ok(allCustomers);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetCustomerById(Guid id)
        {
            var customer = dBContext.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(customer);
            }
        }

        [HttpPost]
        public IActionResult AddCustomer(CustomerAddDto customerAddDto)
        {
            var customer = new Customer()
            {
                FirstName = customerAddDto.FirstName,
                LastName = customerAddDto.LastName,
                Email = customerAddDto.Email,
                Phone = customerAddDto.Phone,
                Address = customerAddDto.Address,
                CustomerType = customerAddDto.CustomerType,
            };

            dBContext.Customers.Add(customer);
            dBContext.SaveChanges();

            return Ok(customer);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpddateCustomer(Guid id, CustomerUpdateDto customerUpdateDto)
        {
            var customer = dBContext.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            else
            {
                customer.FirstName = customerUpdateDto.FirstName;
                customer.LastName = customerUpdateDto.LastName;
                customer.Email = customerUpdateDto.Email;
                customer.Phone = customerUpdateDto.Phone;
                customer.Address = customerUpdateDto.Address;

                dBContext.SaveChanges();
               
                return Ok(customer);
            }
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteCustomer(Guid id) 
        {
            var customer = dBContext.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            else
            {
                dBContext.Customers.Remove(customer);
                dBContext.SaveChanges();

                return Ok();
            }
        }

    }
}
