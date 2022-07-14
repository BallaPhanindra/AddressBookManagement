using System;

namespace AddressBookManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book\n");

            CreateContact.CreateAContact();
            //AddNewContact.AddNewContacts();
            //UpdateExistingContact.UpdateContact();
            //DeleteContact.ContactDelete();
            Console.ReadKey();
        }
    }
}
