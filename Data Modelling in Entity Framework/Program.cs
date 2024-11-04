using System;
using System.Collections.Generic;
using System.Linq; // For LINQ queries
using static Data_Modelling_in_Entity_Framework.YourDbContext;

namespace Data_Modelling_in_Entity_Framework
{

    // ... (Customer, PhoneNumber, and Like classes as provided previously) ...

    public class YourDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Like> Likes { get; set; }
        public object Database { get; internal set; }

        public class PhoneNumber
        {
            public string Number { get; internal set; }
        }

        public class Like
        {
            public string Interest { get; internal set; }
        }

        public class DbContextOptionsBuilder
        {
            internal void UseSqlServer(string v)
            {
                throw new NotImplementedException();
            }
        }

        public class ModelBuilder
        {
            internal object Entity<T>()
            {
                throw new NotImplementedException();
            }
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }


    class Program : ProgramBase
    {
    }
}