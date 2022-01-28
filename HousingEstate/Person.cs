using System;

namespace HousingEstate
{
    class Person
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }
        public override string ToString()
        {
            return FirstName;
        }





    }
}

