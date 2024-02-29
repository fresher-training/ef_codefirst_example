using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiy
{
    [Table("tbl_user")]
    public class User : DbEntity
    {
        #region Properties
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool EmailConfirmed { get; set; } = false;
        #endregion Properties

        public UserDetail? UserDetail { get; set; }

        [NotMapped]
        public string Name
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
