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
                    sw.Write(item.LastName);
                    sw.Write("|");
                    sw.WriteLine(item.FirstName);
                }
                sw.Close();
            }

        }

        public static ArrayList LoadFromFile()
        {
            ArrayList arr = new ArrayList();
            
            string filename = "persons.csv";
            StreamReader sr = File.OpenText(filename);
            while (!sr.EndOfStream)
            {
                String[] fields = sr.ReadLine().Split('|');
                if (fields.Length>=2) 
                {
                    Person person = new Person();
                    person.LastName = fields[0];
                    person.FirstName = fields[1];
                    arr.Add(person);
                }
            }
            sr.Close();
            return arr;
        }


        // public List<String> Compentencies { get; set; }
    }
}
