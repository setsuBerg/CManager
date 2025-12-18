using CManager.Presentation.consoleApp.Controllers;
using CManager.Application.Interfaces;
using CManager.Application.Repositories;
using CManager.Application.Services;

var repository = new CustomerRepository();
var service = new CustomerService(repository);
var menu = new MenuController(service);

menu.Start();