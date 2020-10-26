using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class Program
    {
        /// This list is to hold list of person details        
        public static List<PersonDetails> People = new List<PersonDetails>();
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        public static void Main(string[] args)
        {
            ///To display options to Choose
            Console.WriteLine("********MENU*********");
            Console.WriteLine("Choose the option you want to perform");
            Console.WriteLine("1.Add Person Details");
            ///Reading the option from user
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    AddPerson();
                    break;
            }
        }

        ///Creating a method AddPerson to add person details  
        static void AddPerson()
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
