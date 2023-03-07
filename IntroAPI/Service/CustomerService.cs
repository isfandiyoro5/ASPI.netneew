using IntroAPI.Models;
namespace IntroAPI.Service
{
    public class CustomerService:ICustomerSevice
    {
        private List<Customers> _customers;

        public CustomerService()
        {
            _customers = new List<Customers>();
        }
        public List<Customers> GetCustomers()
        {
            return _customers;
        }
        public Customers AddCustomers(Customers customers)
        {
            _customers.Add(customers);
            
            return customers; 
        }
        public Customers UpdateCustomers(short id,Customers customer)
        {
            for (var index = _customers.Count - 1; index >= 0; index--)
            {
                if (_customers[index].CustomerID==id)
                {
                    _customers[index] = customer;
                }
            }
            return customer;
        }
        public short DeleteCustomers(short id)
        {
           for(var index = _customers.Count - 1; index >= 0; index--)
            {
                if (_customers[index].CustomerID == id)
                {
                    _customers.RemoveAt(index);
                }
            }
           return id;
            
        }

       

    }
}
