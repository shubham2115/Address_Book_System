﻿using System;

namespace Address_Book_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");

            AddressBook.AddContact();
            AddressBook.ContactsDisplay();
            AddressBook.EditContact();
            AddressBook.ContactsDisplay();
        }
    }
}