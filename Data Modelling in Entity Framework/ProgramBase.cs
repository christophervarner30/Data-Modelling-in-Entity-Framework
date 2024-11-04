using System;
using System.Collections.Generic;
using static Data_Modelling_in_Entity_Framework.YourDbContext;

namespace Data_Modelling_in_Entity_Framework
{
    internal class ProgramBase
    {
        static void Main(string[])
        {
            using (YourDbContext db = new YourDbContext())
            {
                // Create the database if it doesn't exist
                object p = db.Database.EnsureCreated();

                // Example of adding a customer with related data
                Customer customer = new Customer
                {
                    FirstName = "John",
                    LastName = "Doe",
                    BirthDate = new DateTime(1980, 1, 1),
                    Address = "123 Main St",
                    Email = "john.doe@example.com",
                    PhoneNumbers = new List<PhoneNumber> { new PhoneNumber { Number = "1212" } },
                    Likes = new List<Like> { new Like { Interest = "Reading" }, new Like { Interest = "Coding" } }
                };

                db.Customers.Add(customer);
                db.SaveChanges();


                // Example of querying data (using LINQ)
                var customersWhoLikeCoding = db.Customers
                    .Where(c =>
                    {
                        return c.Likes.Any(l => l.Interest == "Coding");
                    })
                    .ToList();

                foreach (var c in customersWhoLikeCoding)
                {
                    Console.WriteLine($"{c.FirstName} {c.LastName} likes coding.");
                }

            }

            Console.WriteLine("Done. Press any key to exit.");
            Console.ReadKey();
        }
    }
}