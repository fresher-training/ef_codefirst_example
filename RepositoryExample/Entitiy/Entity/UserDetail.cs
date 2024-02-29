using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiy
{
    [Table("tbl_user_detail")]
    public class UserDetail : DbEntity
    {
        [Key]
        public int Id { get; set; }
        public string Avatar { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
        public DateTimeOffset Birthday { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
