using CManager.Presentation.consoleApp.Interfaces;

namespace CManager.Presentation.consoleApp.Controllers;

public class MenuController
{

    private readonly ICustomerService _customerService;
    public MenuController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    public void Start()
    {
        bool isRunning = true;
        while (isRunning) 
        {
            ShowMainMenu();
            Console.Write("Select a number: ");
            var input = Console.ReadLine();

            switch (input) 
            {
                case "1":
                    Console.WriteLine("FirstName: ");
                    var firstName = Console.ReadLine();
                    Console.WriteLine("LastName: ");
                    var lastName = Console.ReadLine();
                    Console.WriteLine("Email: ");
                    var email = Console.ReadLine();
                    Console.WriteLine("PhoneNumber: ");
                    var phoneNumber = Console.ReadLine();
                    Console.WriteLine("StreetAddress: ");
                    var streetAddress = Console.ReadLine();
                    Console.WriteLine("PostalCode: ");
                    var postalCode = Console.ReadLine();
                    Console.WriteLine("City: ");
                    var city = Console.ReadLine();
                    _customerService.CreateCustomer(firstName, lastName, email, phoneNumber, streetAddress, postalCode, city);
                    break;

                case "2":
                    var customers = _customerService.GetCustomers();
                    foreach (var customer in customers) 
                    {
                        Console.WriteLine($"{customer.FirstName} {customer.LastName} {customer.Email} {customer.PhoneNumber} {customer.Address.StreetAddress} {customer.Address.PostalCode} {customer.Address.City}");
                    }
                    break;

                case "0":
                    isRunning = false;
                    break;

            }
        }
    }

    private static void ShowMainMenu() 
    {

        Console.WriteLine("1. Add new customer");
        Console.WriteLine("2. Show all cuntomers");
        Console.WriteLine("0. Exit");
    }
}
