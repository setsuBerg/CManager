using CManager.Application.Interfaces;
using CManager.Application.Models;
using CManager.Application.Services;
using NSubstitute;


namespace CManager.Tests.Application;

public class CustomerService_Tests
{
    [Fact]
    public void CreateCustomer_ShouldReturnFalse_WhenEmailAlreadyExists()
    {
        //arrange
        var repository = Substitute.For<ICustomerRepository>(); //Mocks repository
        repository.GetAllCustomers().Returns(new List<CustomerModel> { new CustomerModel { Email = "se@domain.com" } });

        var customerService = new CustomerService(repository);


        // act
        var result = customerService.CreateCustomer("Setsu", "Suzuki", "se@domain.com", "0700006666", "hhgatan 2", "00011", "Lund");
        

        //assert
        Assert.False(result);
        repository.DidNotReceive().SaveAllCustomers(Arg.Any<List<CustomerModel>>());
    }

    [Fact]
    public void CreateCustomer_ShouldReturnTrue_WhenCustomerIsCreatedSuccessfully()
    {
        //arrange
        var repository = Substitute.For<ICustomerRepository>();
        repository.GetAllCustomers().Returns(new List<CustomerModel>());

        var customerService = new CustomerService(repository);


        // act
        var result = customerService.CreateCustomer("Setsu", "Suzuki", "se@domain.com", "0700006666", "hhgatan 2", "00011", "Lund");


        //assert
        Assert.True(result);
        repository.Received(1).SaveAllCustomers(Arg.Any<List<CustomerModel>>());
    }
}