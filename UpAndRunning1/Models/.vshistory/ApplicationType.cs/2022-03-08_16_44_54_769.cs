using System.ComponentModel.DataAnnotations;

namespace UpAndRunning1.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
