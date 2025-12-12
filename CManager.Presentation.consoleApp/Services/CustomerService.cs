using System.Linq;
using CManager.Presentation.consoleApp.Interfaces;
using CManager.Presentation.consoleApp.Models;
using CManager.Presentation.consoleApp.Repositories;
using System.Reflection.Metadata.Ecma335;

namespace CManager.Presentation.consoleApp.Services;

public class CustomerService : ICustomerService
{

    private readonly ICustomerRepository _CustomerRepository;
    public CustomerService(ICustomerRepository customerRepository) => _CustomerRepository = customerRepository;

    public bool CreateCustomer(string firstName, string lastName, string email, string phoneNumer, string streetAddress, string postalCode, string city)
    {
        var customers = _CustomerRepository.GetAllCustomers();

        if (customers.Any(c => c.Email == email))
            return false;

        var customer = new CustomerModel
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            PhoneNumber = phoneNumer,
            Address = new AddressModel
            {
                StreetAddress = streetAddress,
                PostalCode = postalCode,
                City = city
            }
        };

        customers.Add(customer);
        _CustomerRepository.SaveAllCustomers(customers);
        return true;
    }

    public IEnumerable<CustomerModel> GetCustomers()
    {
        throw new NotImplementedException();
    }
}
