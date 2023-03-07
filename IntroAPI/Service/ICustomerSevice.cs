using IntroAPI.Models;

namespace IntroAPI.Service
{
    public interface ICustomerSevice
    {
        public List<Customers> GetCustomers();
        public Customers AddCustomers(Customers customers);
        public Customers UpdateCustomers(short id, Customers customer);

        public short DeleteCustomers(short id);
    }
}
