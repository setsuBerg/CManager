using CManager.Application.Models;

namespace CManager.Application.Interfaces;

public interface ICustomerService
{
    bool CreateCustomer(string firstName, string lastName, string email, string phoneNumber, string streetAddress, string postalCode, string city);

    IEnumerable<CustomerModel> GetCustomers();

    CustomerModel? GetCustomerByEmail(string email);
    bool RemoveCustomerByEmail(string email);


}
