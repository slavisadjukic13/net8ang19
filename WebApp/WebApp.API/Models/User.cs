namespace WebApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string EmailConfirmed { get; set; } = string.Empty;
        public string PasswordConfirmed { get; set; } = string.Empty;

    }
}
