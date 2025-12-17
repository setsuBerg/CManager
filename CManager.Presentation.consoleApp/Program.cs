using CManager.Presentation.consoleApp.Controllers;
using CManager.Presentation.consoleApp.Interfaces;
using CManager.Presentation.consoleApp.Repositories;
using CManager.Presentation.consoleApp.Services;

var repository = new CustomerRepository();
var service = new CustomerService(repository);
var menu = new MenuController(service);

menu.Start();