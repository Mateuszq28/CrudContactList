using System.ComponentModel.DataAnnotations;

namespace CrudContactList.Models
{
    public class Contact
    {
        public string name { get; set; }
        public string surname { get; set; }
        // unique
        [KeyAttribute]
        [RegularExpression(@"^.*@.*$")]
        public string email { get; set; }
        // strong password
        public string password { get; set; }
        // w - combo box
        public string category { get; set; }
        // optional
        // w - combo box or text field
        public string? subcategory { get; set; }
        // regular expression
        [RegularExpression(@"^\d{3}-\d{3}-\d{3}$")]
        public string phone { get; set; }
        // only date
        [DataType(DataType.Date)]
        public DateTime birthDate { get; set; }

        public Contact()
        {

        }
    }
}
