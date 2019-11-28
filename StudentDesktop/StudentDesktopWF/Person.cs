using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;

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
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            //settings.Encoding = "utf-8";
            
            //string filename = "persons.csv";
            string filename = "persons.xml";
            XmlWriter xmlWriter = XmlWriter.Create(filename,settings);
            //xmlWriter.R
            //пишем заголовок и корень документа
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("persons");


            if (arr != null)
            {
            //    StreamWriter sw = File.CreateText(filename);
                foreach (Person item in arr)
                {
                    xmlWriter.WriteStartElement("person");
                    xmlWriter.WriteElementString("LastName", item.LastName);
                    xmlWriter.WriteElementString("FirstName", item.FirstName);
                    xmlWriter.WriteElementString("Birthday", item.Birthday.ToString());
                    xmlWriter.WriteElementString("Department", item.Department);
                    xmlWriter.WriteElementString("Competences", item.GetCompetenceList());
                    xmlWriter.WriteEndElement();

                    //        sw.Write(item.LastName);
                    //        sw.Write("|");
                    //        sw.Write(item.FirstName);
                    //        sw.Write("|");
                    //        sw.Write(item.Birthday);
                    //        sw.Write("|");
                    //        sw.Write(item.Department);
                    //        sw.Write("|");
                    //        sw.WriteLine(item.GetCompetenceList());
                }
            //    sw.Close();
            }

            //закрываем корень и сам документ
            xmlWriter.WriteEndElement();
            xmlWriter.Close();

        }

    public static ArrayList LoadFromFile()
        {
            ArrayList arr = new ArrayList();

            //string filename = "persons.csv";
            string filename = "persons.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);

            //получим root-Документ
            XmlElement root = doc.DocumentElement;

            //обойдем все документы в root
            foreach(XmlNode node in root)
            {
                Person person = new Person();
                //обходим все дочерние узлы элемента Person
                foreach (XmlNode childNote in node.ChildNodes)
                {
                    if (childNote.Name=="LastName")
                    {
                        person.LastName = childNote.InnerText;
                    }
                    if (childNote.Name == "FirstName")
                    {
                        person.FirstName = childNote.InnerText;
                    }
                    if (childNote.Name == "Birthday")
                    {
                        person.Birthday = Convert.ToDateTime(childNote.InnerText);
                    }
                    if (childNote.Name == "Department")
                    {
                        person.Department = childNote.InnerText;
                    }
                    if (childNote.Name == "Competences")
                    {
                        person.SetCompetenceList(childNote.InnerText);
                    }
                }
                arr.Add(person);
            }

            
            //StreamReader sr = File.OpenText(filename);
            //while (!sr.EndOfStream)
            //{
            //    String[] fields = sr.ReadLine().Split('|');
            //    if (fields.Length >= 2)
            //    {
            //        Person person = new Person();
            //        person.LastName = fields[0];
            //        person.FirstName = fields[1];
            //        person.Birthday = Convert.ToDateTime(fields[2]);
            //        person.Department = fields[3];
            //        person.SetCompetenceList(fields[4]);
            //        arr.Add(person);
            //    }
            //}
            //sr.Close();
            return arr;
        }


       
    }
}
