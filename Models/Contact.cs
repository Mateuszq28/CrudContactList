using System.ComponentModel.DataAnnotations;

namespace CrudContactList.Models
{
    public class Contact
    {
        // an email could also work as an Id
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        // unique
        public string email { get; set; }
        // strong password
        public string password { get; set; }
        // unique
        // w - combo box
        public string category { get; set; }
        // optional
        // w - combo box or text field
        public string? subcategory { get; set; }
        // regular extension
        public string phone { get; set; }
        [DataType(DataType.Date)]
        public DateTime birthDate { get; set; }
    }
}
