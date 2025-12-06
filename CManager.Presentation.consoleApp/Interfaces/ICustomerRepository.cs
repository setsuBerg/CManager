using CManager.Presentation.consoleApp.Models;

namespace CManager.Presentation.consoleApp.Interfaces;

public interface ICustomerRepository
{
    void SaveAllCustomers(List<Customer> customers);

    List<Customer> GetAllCustomers();
}
