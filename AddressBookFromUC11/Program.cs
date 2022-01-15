using System;

namespace AddressBookFromUC11
{
    public interface IAddressBook
    {
        void ViewAllAddressBooks();
        void DeleteAddressBook();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
        }
    }
}
