using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class Program
    {
        /// This list is to hold list of person details        
        public static List<PersonDetails> People = new List<PersonDetails>();
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {

            
            
        }

        ///Creating a method AddPerson to add person details  
        public static void AddPerson()
        {
            ///Creating a new Person object called person from the class PersonDetails
            PersonDetails person = new PersonDetails();
            Console.WriteLine("Enter Person FirstName");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Person LastName");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Enter Person Address");
            person.Address = Console.ReadLine();
            Console.WriteLine("Enter Person City");
            person.City = Console.ReadLine();
            Console.WriteLine("Enter Person State");
            person.State = Console.ReadLine();
            Console.WriteLine("Enter ZipCode");
            person.ZipCode = Console.ReadLine();
            Console.WriteLine("Enter Person PhoneNUmber");
            person.PhoneNumber = Console.ReadLine();
            People.Add(person);
        }
    }
}
