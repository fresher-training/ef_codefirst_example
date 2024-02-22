using System.ComponentModel.DataAnnotations;

namespace EFCoreFirstExample.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool EmailConfirmed { get; set; } = false;

        public UserDetail? UserDetail { get; set; }
    }
}
