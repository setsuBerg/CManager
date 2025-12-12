using CManager.Presentation.consoleApp.Models;

namespace CManager.Presentation.consoleApp.Interfaces;

public interface ICustomerRepository
{
    void SaveAllCustomers(List<CustomerModel> customers);

    List<CustomerModel> GetAllCustomers();
}
