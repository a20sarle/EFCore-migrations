using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationCodeFirst.Models
{
    public class SqlWorker
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
