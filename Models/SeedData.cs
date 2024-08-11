using Microsoft.EntityFrameworkCore;
using CrudContactList.Data;
using System.ComponentModel.DataAnnotations;

namespace CrudContactList.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationDbContext>>()))
        {
            if (context == null || context.Contact == null)
            {
                throw new ArgumentNullException("Null ApplicationDbContext");
            }

            // Look for any Contacts.
            if (!context.Contact.Any())
            {

                context.Contact.AddRange(
                    new Contact
                    {
                        name = "Jan",
                        surname = "Nowak",
                        email = "jan@nowak.pl",
                        password = "12d_54$%_12Fd",
                        category = "służbowy",
                        subcategory = "szef",
                        phone = "111-111-111",
                        birthDate = DateTime.Parse("1990-3-13")
                    },

                    new Contact
                    {
                        name = "Anna",
                        surname = "Kowalska",
                        email = "anna@kowalska.pl",
                        password = "12d_54$%_12Fd",
                        category = "służbowy",
                        subcategory = "klient",
                        phone = "222-111-111",
                        birthDate = DateTime.Parse("1992-3-13")
                    },

                    new Contact
                    {
                        name = "Beata",
                        surname = "Jaworska",
                        email = "beata@jaworska.pl",
                        password = "12d_54$%_12Fd",
                        category = "prywatny",
                        subcategory = null,
                        phone = "333-111-111",
                        birthDate = DateTime.Parse("1993-3-13")
                    },

                    new Contact
                    {
                        name = "Marek",
                        surname = "Rolada",
                        email = "marek@rolada.pl",
                        password = "12d_54$%_12Fd",
                        category = "inny",
                        subcategory = "fotowoltaika",
                        phone = "444-111-111",
                        birthDate = DateTime.Parse("1994-3-13")
                    }
                );
                context.SaveChanges();
            }
            
            // Look for any Categories.
            if (!context.Category.Any())
            {

                context.Category.AddRange(
                    new Category
                    {
                        Name = "Służbowy"
                    },
                    
                    new Category
                    {
                        Name = "Prywatny"
                    },
                    
                    new Category
                    {
                        Name = "Inny"
                    }
                );
                context.SaveChanges();
            }

            // Look for any Subcategory.
            if (!context.Subcategory.Any())
            {

                context.Subcategory.AddRange(
                    new Subcategory
                    {
                        Name = "Szef"
                    },
                    
                    new Subcategory
                    {
                        Name = "Klient"
                    },
                    
                    new Subcategory
                    {
                        Name = "Pani Basia"
                    }
                );
                context.SaveChanges();
            }

        }
    }
}