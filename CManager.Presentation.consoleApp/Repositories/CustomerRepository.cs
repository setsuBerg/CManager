using CManager.Presentation.consoleApp.Interfaces;
using CManager.Presentation.consoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Presentation.consoleApp.Repositories;

public class CustomerRepository : ICustomerRepository
{
    public List<CustomerModel> GetAllCustomers()
    {
        throw new NotImplementedException();
    }

    public void SaveAllCustomers(List<CustomerModel> customers)
    {
        throw new NotImplementedException();
    }
}
