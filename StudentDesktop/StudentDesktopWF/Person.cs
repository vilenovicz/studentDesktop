using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace vcz.StudentDesktopWF
{
    public class Person
    {
        DateTime birthday = DateTime.Now;
        List<String> competenceList = new List<String>();

        public List<String> CompetenceList
        {
            get { return competenceList; }
            set { competenceList = value; }
        }

        public string GetCompetenceList()
        {
            string res = "";
            
//            Object[] arr = competenceList.ToArray();
            foreach(String item in competenceList)
            {
                res += item;
                res += ",";
            }
            return res;
        }

        public void SetCompetenceList(string list)
        {
            List<String> competences = new List<String>();
            if (list!=null)
            {
                foreach(String item in list.Split(','))
                {
                    competences.Add(item);
                }
            }
            this.competenceList = competences;
        }
        
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday 
        {
            get { return birthday; }
            set
            { 
                //Дата рождения не может быть больше текущей даты ;)
                if (value < DateTime.Now)
                {
                    birthday = value;
                }
            }
        }

        public string Department { get; set; }

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
                    sw.Write(item.FirstName);
                    sw.Write("|");
                    sw.Write(item.Birthday);
                    sw.Write("|");
                    sw.Write(item.Department);
                    sw.Write("|");
                    sw.WriteLine(item.GetCompetenceList());
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
                if (fields.Length >= 2)
                {
                    Person person = new Person();
                    person.LastName = fields[0];
                    person.FirstName = fields[1];
                    person.Birthday = Convert.ToDateTime(fields[2]);
                    person.Department = fields[3];
                    person.SetCompetenceList(fields[4]);
                    arr.Add(person);
                }
            }
            sr.Close();
            return arr;
        }


       
    }
}
