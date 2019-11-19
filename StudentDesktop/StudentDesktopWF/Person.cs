using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDesktopWF
{
    public class Person
    {
        public Person(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public DateTime Birthday { get; set; }

        public List<String> Compentencies { get; set; }
    }
}
