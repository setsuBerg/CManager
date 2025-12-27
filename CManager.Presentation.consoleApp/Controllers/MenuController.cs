using CManager.Application.Interfaces;
using CManager.Application.Models;
using CManager.Presentation.consoleApp.Validators;
using System.Linq;

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
                    Console.Write("FirstName: ");
                    var firstName = (Console.ReadLine() ?? "").Trim();
                    Console.Write("LastName: ");
                    var lastName = (Console.ReadLine() ?? "").Trim();

                    string email;
                    bool isValid;
                    do
                    {
                        Console.Write("Email: ");
                        email = (Console.ReadLine() ?? "").Trim();

                        isValid = EmailValidator.IsValid(email);

                        if (!isValid)
                            Console.WriteLine("Try again.");
                    }
                    while (!isValid);
                    


                    Console.Write("PhoneNumber: ");
                    var phoneNumber = (Console.ReadLine() ?? "").Trim();
                    Console.Write("StreetAddress: ");
                    var streetAddress = (Console.ReadLine() ?? "").Trim();
                    Console.Write("PostalCode: ");
                    var postalCode = (Console.ReadLine() ?? "").Trim();
                    Console.Write("City: ");
                    var city = (Console.ReadLine() ?? "").Trim();

                    var created = _customerService.CreateCustomer(firstName, lastName, email, phoneNumber, streetAddress, postalCode, city);
                    
                    Console.WriteLine(created ? "Customer added." : "Customer already exists.");

                    Console.WriteLine("\nPress any key to return to menu.");
                    Console.ReadKey();
                    break;


                case "2":
                    var customers = _customerService.GetCustomers();
                    if (customers == null || customers.Count() == 0) 
                    {
                        Console.WriteLine("No customers found.");
                        Console.ReadKey();
                        break;
                    }
           

                    foreach (var customer in customers) 
                    {
                        Console.WriteLine($"{customer.Id} {customer.FirstName} {customer.LastName} {customer.Email} {customer.PhoneNumber} {customer.Address.StreetAddress} {customer.Address.PostalCode} {customer.Address.City}");
                    }
                    Console.WriteLine("\nPress any key to return to menu.");
                    Console.ReadKey();
                    break;


                case "3":
                    Console.Write("Email: ");
                    var emailToShow = (Console.ReadLine() ?? "").Trim();

                    var customerToShow = _customerService.GetCustomerByEmail(emailToShow);

                    if (customerToShow == null)
                        Console.WriteLine("The customer is not found.");
                    else
                        Console.WriteLine($"{customerToShow.Id} {customerToShow.FirstName} {customerToShow.LastName} {customerToShow.Email}");

                    Console.WriteLine("\nPress any key to return to menu.");
                    Console.ReadKey();
                    break;


                case "4":
                    Console.Write("Email to delete: ");
                    var emailToDelete = (Console.ReadLine() ?? "").Trim();
                    
                    var removed = _customerService.RemoveCustomerByEmail(emailToDelete);
                    if (removed)
                        Console.WriteLine("Customer removed");
                    else
                        Console.WriteLine("The customer is not found.");

                    Console.WriteLine("\nPress any key to return to menu.");
                    Console.ReadKey();
                    break;

                case "0":
                    isRunning = false;
                    break;

                default : Console.WriteLine("Please enter a number from the menu.");
                    break;
            }
        }
    }

    private static void ShowMainMenu() 
    {
        Console.Clear();
        Console.WriteLine("Customer Manager");
        Console.WriteLine("1. Create new customer");
        Console.WriteLine("2. Show all customers");
        Console.WriteLine("3. Show a customer by email");
        Console.WriteLine("4. Delete a customer by email");
        Console.WriteLine("0. Exit");
    }
}
