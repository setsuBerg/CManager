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

        if (!File.Exists(_filePath))
            return new List<CustomerModel>();

        var json = File.ReadAllText(_filePath);

        var cutomers = JsonSerializer.Deserialize<List<CustomerModel>>(json);
        return cutomers ?? new List<CustomerModel>();

    }

    public void SaveAllCustomers(List<CustomerModel> customers)
    {
        var json = JsonSerializer.Serialize(customers);

        File.WriteAllText(_filePath, json);
    }
}
