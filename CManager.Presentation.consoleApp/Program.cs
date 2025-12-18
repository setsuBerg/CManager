using CManager.Presentation.consoleApp.Controllers;
using CManager.Application.Interfaces;
using CManager.Application.Repositories;
using CManager.Application.Services;

ICustomerRepository repository = new CustomerRepository();
ICustomerService service = new CustomerService(repository);
var menu = new MenuController(service);

menu.Start();