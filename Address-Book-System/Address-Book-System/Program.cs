using System;

namespace Address_Book_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");

            AddressBook.addAddressBook();
            Console.WriteLine("\n");
            AddressBook.ContactsDisplay();
            Console.WriteLine("\n");
            AddressBook.EditContact();
            Console.WriteLine("\n");
            AddressBook.ContactsDisplay();
            Console.WriteLine("\n");
            AddressBook.ContactsDisplay();
            AddressBook.ContactsDisplay();
            AddressBook.ContactsDisplay();
            AddressBook.ContactsDisplay();
        }
    }
}