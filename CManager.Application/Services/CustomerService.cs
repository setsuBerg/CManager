using System.Linq;
using CManager.Application.Interfaces;
using CManager.Application.Models;

namespace CManager.Application.Services;

public class CustomerService : ICustomerService
{

    private readonly ICustomerRepository _customerRepository;
    public CustomerService(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

    public bool CreateCustomer(string firstName, string lastName, string email, string phoneNumer, string streetAddress, string postalCode, string city)
    {
        var customers = _customerRepository.GetAllCustomers();

        if (customers.Any(c => string.Equals(c.Email, email, StringComparison.OrdinalIgnoreCase)))
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
        _customerRepository.SaveAllCustomers(customers);
        return true;
    }

    public IEnumerable<CustomerModel> GetCustomers()
    {
        return _customerRepository.GetAllCustomers();
    }

    public CustomerModel? GetCustomerByEmail(string email) 
    {
        var customers = _customerRepository.GetAllCustomers();
        return customers.FirstOrDefault(c => c.Email == email);
    }
    public bool RemoveCustomerByEmail(string email) 
    {
        var customers = _customerRepository.GetAllCustomers();
        var customer = customers.FirstOrDefault(c => c.Email == email);
        if (customer == null)
            return false;
        
        customers.Remove(customer);
        _customerRepository.SaveAllCustomers(customers);
        return true;
    }
}
