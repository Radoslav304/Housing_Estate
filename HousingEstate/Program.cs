
using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Radoslav";
            Console.WriteLine(person.ToString());

        }
    }
}
