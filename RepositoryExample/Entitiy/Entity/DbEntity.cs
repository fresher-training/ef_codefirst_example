using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiy
{
    public abstract class DbEntity
    {
        public Guid Id { get; set; }

        public string CreatedBy { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; }

        public string LastUpdateBy { get; set; } = string.Empty;

        public DateTime LastUpdateDate { get; set; }
    }
}
