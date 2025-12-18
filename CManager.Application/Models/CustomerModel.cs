using System.Security.Principal;

namespace CManager.Application.Models;

public class CustomerModel
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }

    public AddressModel Address { get; set; } = new();
    
}
