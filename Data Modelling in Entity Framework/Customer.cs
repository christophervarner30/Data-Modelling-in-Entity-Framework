using System;
using System.Collections.Generic;

namespace Data_Modelling_in_Entity_Framework
{
    public class Customer
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public DateTime BirthDate { get; internal set; }
        public string Address { get; internal set; }
        public string Email { get; internal set; }
        public System.Collections.Generic.List<PhoneNumber> PhoneNumbers { get; internal set; }
        public List<YourDbContext.Like> Likes { get; internal set; }

        public static implicit operator Customer(Customer v)
        {
            throw new NotImplementedException();
        }
    }
}