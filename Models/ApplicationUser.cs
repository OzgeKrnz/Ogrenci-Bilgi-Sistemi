using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace StajProjesi.Models;

public class ApplicationUser:IdentityUser
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    
}