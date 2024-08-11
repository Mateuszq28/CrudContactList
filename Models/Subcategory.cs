using System.ComponentModel.DataAnnotations;

namespace CrudContactList.Models
{
    public class Subcategory
    {
        [KeyAttribute]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public Subcategory()
        {
            
        }
    }
}
