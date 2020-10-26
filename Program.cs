using System;
using System.Collections.Generic;
using System.Linq;

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
            Console.WriteLine("1.Add Person Details\n 2.Print Entries and person Details\n 3.Remove Person Details");
            ///Reading the option from user
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    AddPerson();
                    break;
                case 2:
                    PrintEntries();
                    break;
                case 3:
                    RemovePersonDetails();
                    break;
            }
        }

        private static void PrintEntries()
        {
            throw new NotImplementedException();
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
        ///Creating method to Print Person Details
        private static void PrintEntries(PersonDetails person)
        {
            Console.WriteLine("First Name:" + person.FirstName);
            Console.WriteLine("Last Name:" + person.LastName);
            Console.WriteLine("Address:" + person.Address);
            Console.WriteLine("City:" + person.City);
            Console.WriteLine("State:" + person.State);
            Console.WriteLine("ZipCode:" + person.ZipCode);
            Console.WriteLine("Phone Number:" + person.PhoneNumber);
        }
        ///Method to check if there are any entries
        private static void ListPeople()
        {
            ///Condition to check Addre book empty or not
            if(People.Count==0)
            {
                Console.WriteLine("Your Address book is Empty, Press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in Address book");
            ///tracing all the entries using foreach loop
            foreach(var person in People)
            {
                PrintEntries(person);
                Console.WriteLine("Your Address book is Empty, Press any key to continue");
                Console.ReadKey();
            }
        }
        /// Method to remove entries
        public static void RemovePersonDetails()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove");
            string FirstName = Console.ReadLine();
            PersonDetails person = People.FirstOrDefault(x => x.FirstName.ToLower() == FirstName.ToLower());
            ///Condition to check the person is found or not
            if(person==null)
            {
                Console.WriteLine("The person could not found. press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Are you sure you want to remove?(Y/N)");
            ///Printing person details
            PrintEntries(person);
            ///Condition to check whether want to remove person for sure
            if(Console.ReadKey().Key==ConsoleKey.Y)
            {
                ///calling remove method
                People.Remove(person);
                Console.WriteLine("Person removed. press any key to continue");
                Console.ReadKey();
            }

        }
    }
}
