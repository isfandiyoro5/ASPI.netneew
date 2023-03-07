using IntroAPI.Models;
using IntroAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerSevice _customerservice;
        public CustomerController(ICustomerSevice service)
        {
            _customerservice = service; 
        }

        [HttpPost]
        public ActionResult<Customers> Create(Customers customer)
        {
            _customerservice.AddCustomers(customer);
            return  Ok(); 
        }
        [HttpGet]
        public ActionResult<List<Customers>> GetAllCustomers()
        {
            return Ok(_customerservice.GetCustomers());
        }
        [HttpPut]
        public ActionResult<Customers> UpdateCustomers(short id,Customers customers)
        {
            _customerservice.UpdateCustomers(id,customers);
            return customers;
        }
        [HttpDelete]
        public ActionResult<short> DeleteProduct(short id)
        {
            _customerservice.DeleteCustomers(id);
            return id;
        }
    } 
}





















































