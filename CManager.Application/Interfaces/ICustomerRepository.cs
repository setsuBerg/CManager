using CManager.Application.Models;

namespace CManager.Application.Interfaces;

public interface ICustomerRepository
{
    void SaveAllCustomers(List<CustomerModel> customers);

    List<CustomerModel> GetAllCustomers();
}
