using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CManager.Presentation.consoleApp.Controllers;
using CManager.Application.Interfaces;
using CManager.Application.Repositories;
using CManager.Application.Services;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<ICustomerRepository, CustomerRepository>();
builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddSingleton<MenuController>();

var app = builder.Build();

var menu = app.Services.GetRequiredService<MenuController>();

menu.Start();