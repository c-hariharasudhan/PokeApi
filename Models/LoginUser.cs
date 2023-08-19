using System.ComponentModel.DataAnnotations;

namespace PokeApi.Models;

public class LoginUser {
    [Required]
    public string Email {get;set;}
    [Required]
    public string Password {get;set;}
}