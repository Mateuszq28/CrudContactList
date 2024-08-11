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
            
            // Look for any Categories.
            if (!context.Category.Any())
            {

                context.Category.AddRange(
                    new Category
                    {
                        Id = 1,
                        Name = "Business"
                    },
                    
                    new Category
                    {
                        Id = 2,
                        Name = "Private"
                    },
                    
                    new Category
                    {
                        Id = 3,
                        Name = "Other"
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
                        Id = 1,
                        CategoryId = 1,
                        Name = "Boss"
                    },
                    
                    new Subcategory
                    {
                        Id = 2,
                        CategoryId = 1,
                        Name = "Client"
                    },
                    
                    new Subcategory
                    {
                        Id = 3,
                        CategoryId = 1,
                        Name = "Mrs. Basia"
                    },
                    
                    new Subcategory
                    {
                        Id = 4,
                        CategoryId = 3,
                        Name = "fotowoltaika"
                    }
                );
                context.SaveChanges();
            }

            // Look for any Contacts.
            if (!context.Contact.Any())
            {

                context.Contact.AddRange(
                    new Contact
                    {
                        Name = "Jan",
                        Surname = "Nowak",
                        Email = "jan@nowak.pl",
                        Password = "12d_54$%_12Fd",
                        CategoryId = 1,
                        SubcategoryId = 1,
                        Phone = "111-111-111",
                        BirthDate = DateTime.Parse("1990-3-13")
                    },

                    new Contact
                    {
                        Name = "Anna",
                        Surname = "Kowalska",
                        Email = "anna@kowalska.pl",
                        Password = "12d_54$%_12Fd",
                        CategoryId = 1,
                        SubcategoryId = 2,
                        Phone = "222-111-111",
                        BirthDate = DateTime.Parse("1992-3-13")
                    },

                    new Contact
                    {
                        Name = "Beata",
                        Surname = "Jaworska",
                        Email = "beata@jaworska.pl",
                        Password = "12d_54$%_12Fd",
                        CategoryId = 2,
                        SubcategoryId = null,
                        Phone = "333-111-111",
                        BirthDate = DateTime.Parse("1993-3-13")
                    },

                    new Contact
                    {
                        Name = "Marek",
                        Surname = "Rolada",
                        Email = "marek@rolada.pl",
                        Password = "12d_54$%_12Fd",
                        CategoryId = 3,
                        SubcategoryId = 4,
                        Phone = "444-111-111",
                        BirthDate = DateTime.Parse("1994-3-13")
                    }
                );
                context.SaveChanges();
            }

        }
    }
}