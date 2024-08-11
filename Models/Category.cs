using System.ComponentModel.DataAnnotations;

namespace CrudContactList.Models
{
    public class Category
    {
        [KeyAttribute]
        public int Id { get; set; }
        public string Name { get; set; }

        public Category()
        {
            
        }
    }
}
