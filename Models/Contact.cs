using System.ComponentModel.DataAnnotations;

namespace CrudContactList.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        // unique
        [KeyAttribute]
        [RegularExpression(@"^.*@.*$")]
        public string Email { get; set; }
        // strong password
        public string Password { get; set; }
        // w - combo box
        public int CategoryId { get; set; }
        // optional
        // w - combo box or text field
        public int? SubcategoryId { get; set; }
        // regular expression
        [RegularExpression(@"^\d{3}-\d{3}-\d{3}$")]
        public string Phone { get; set; }
        // only date
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public Contact()
        {

        }
    }
}
