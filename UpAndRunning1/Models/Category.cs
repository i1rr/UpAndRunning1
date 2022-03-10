using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UpAndRunning1.Models
{ 
    /**
     *  1. add-migration addCategoryToDatabase (in Package Manager Console) - to migrate this class to DB
     *  2. update-database - to push the update
     */
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "Display Oreder for category must be greater than 0")]
        public int DisplayOrder { get; set; }

    }
}

