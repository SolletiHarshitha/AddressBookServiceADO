using System;

namespace AddressBookService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book Service");
            AddressBookRepository repository = new AddressBookRepository();
            ContactDetails details = new ContactDetails();
            details.FirstName = "Kiranmayi";
            details.LastName = "P";
            details.Address = "C.S.Puram Road";
            details.City = "Pamur";
            details.State = "AndhraPradesh";
            details.zip = 523108;
            details.PhoneNumber = 7867567856;
            details.Email = "kiranmayi@gmail.com";
            details.ContactType = "Professsion";
            details.AddressBookName = "Office";
            repository.AddContact(details);
        }
    }
}
