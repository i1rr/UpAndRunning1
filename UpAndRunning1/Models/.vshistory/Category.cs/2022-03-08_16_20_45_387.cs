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

        public string Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }

    }
}

