using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkExample.Models
{
    public class SqlExcludeInMigration
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
