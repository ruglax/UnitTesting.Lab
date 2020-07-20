using System.Collections.Generic;

namespace Lab.Silosys.WinFormsMVP.Model
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();

        Customer GetCustomer(int id);

        void SaveCustomer(int id, Customer customer);
    }
}
