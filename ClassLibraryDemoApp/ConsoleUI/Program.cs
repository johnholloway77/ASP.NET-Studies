/*
 Application for the comparison of .NET Framework and modern .NET/.NET Core libraries

If a .NET Core application relies on a .NET Framework library, it will NOT be cross platform.
The entire application is limited to the lowest level of compatability. 
 
 */


//using FrameworkLibrary; //.NET Framework library
using CoreLibrary;

namespace ConsoleUI
{
    
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Generators generators = new Generators();
            PersonModel person = new PersonModel 
            {
                Prefix = "Mr.",
                FirstName = "John",
                LastName = "Holloway"
            };

            string message = generators.WelcomeMessage("Mr.", "Corey");
            string message2 = generators.WelcomeMessage(person.Prefix, person.LastName);

            Console.WriteLine(message);
            Console.WriteLine(message2);
            Console.ReadLine();
        }
    }
}