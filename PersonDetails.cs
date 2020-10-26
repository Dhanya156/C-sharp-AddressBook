using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    /// <summary>
    /// This class is to create person details like Person firstName, lastName
    /// address, city, state, zipCode and phoneNumber
    /// </summary>
    public class PersonDetails
    {
        ///PersonDetails class will be framework for each person that will stored in AddressBook
        ///Below are the string properties to set person details
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
