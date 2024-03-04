using System.Security.Principal;
using Microsoft.AspNetCore.Identity;

namespace QuizApp;

public class User : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

}
