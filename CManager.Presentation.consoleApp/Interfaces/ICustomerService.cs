using CManager.Presentation.consoleApp.Models;

namespace CManager.Presentation.consoleApp.Interfaces;

public interface ICustomerService
{
    bool CreateCustomer(string firstName, string lastName, string email, string phoneNumber, string streetAddress, string postalCode, string city);

    IEnumerable<CustomerModel> GetCustomers();


}
