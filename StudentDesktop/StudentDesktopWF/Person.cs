using System;
using System.Collections.Generic;

namespace vcz.StudentDesktopWF
{
    public class Person
    {

        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public DateTime Birthday { get; set; }

        public Person(string lastName, string firstName, DateTime birthday)
        {
            LastName = lastName;
            FirstName = firstName;
            Birthday = birthday;
        }

        public Person(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public override string ToString()
        {
            return this.LastName + " " + this.FirstName;
        }

        public void SaveToFile(Person persons)
        {
            string filename = "~\\persons.csv";

        }


        // public List<String> Compentencies { get; set; }
    }
}
