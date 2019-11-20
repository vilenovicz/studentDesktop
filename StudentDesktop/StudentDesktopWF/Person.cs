using System;
using System.Collections;
using System.IO;

namespace vcz.StudentDesktopWF
{
    public class Person
    {

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }

        public Person(string lastName, string firstName, DateTime birthday)
        {
            LastName = lastName;
            FirstName = firstName;
            Birthday = birthday;
        }

        public Person()
        {
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

        public static void SaveToFile(ArrayList arr)
        {
            string filename = "persons.csv";

            if (arr != null)
            {
                StreamWriter sw = File.CreateText(filename);
                foreach (Person item in arr)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
            }

        }



        // public List<String> Compentencies { get; set; }
    }
}
