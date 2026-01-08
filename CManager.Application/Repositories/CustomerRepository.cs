using CManager.Application.Interfaces;
using CManager.Application.Models;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace CManager.Application.Repositories;

public class CustomerRepository : ICustomerRepository
{

    private readonly string _filePath = "data.json";

    public List<CustomerModel> GetAllCustomers()
    {
        try
        {
            if (!File.Exists(_filePath))
                return new List<CustomerModel>();

            var json = File.ReadAllText(_filePath);

            var customers = JsonSerializer.Deserialize<List<CustomerModel>>(json);
            return customers ?? new List<CustomerModel>();
        }
        catch 
        {
            return new List<CustomerModel>();
        }
    }

    public void SaveAllCustomers(List<CustomerModel> customers)
    {
        try
        {
            var json = JsonSerializer.Serialize(customers);

            File.WriteAllText(_filePath, json);
        }
        catch
        {
            // Handle exceptions as needed
        }
    }
}

/* The repository only performs data saving so it doesn't show any error messages.
   I use try and catch here to avoid crashes and let other layers handle error processing and user feedback. */

