using System;
using System.Collections;
using System.IO;
using System.Xml;

namespace StudentDesktopWF
{
    public class Competence
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public Competence(string code, string name)
        {
            Code = code;
            Name = name;
        }
 
        public Competence()
        {
            //
        }


        public override string ToString()
        {
            return "(" + this.Code + "):" + this.Name;
        }

        public static void SaveToFile(ArrayList compArr)
        {
            //string filename = "comp.csv";
            string filename = "comp.xml";

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            //settings.Encoding = "utf-8";


            XmlWriter xmlWriter = XmlWriter.Create(filename, settings);
            //пишем заголовок и корень документа
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("competences");

            if (compArr != null)
            {
            //    StreamWriter sw = File.CreateText(filename);
                foreach (Competence item in compArr)
                {
                    xmlWriter.WriteStartElement("competence");
                    xmlWriter.WriteElementString("Code", item.Code);
                    xmlWriter.WriteElementString("Name", item.Name);
                    xmlWriter.WriteEndElement();
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

            //string filename = "comp.csv";
            string filename = "comp.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);

            //получим root-Документ
            XmlElement root = doc.DocumentElement;

            //обойдем все документы в root
            foreach (XmlNode node in root)
            {
                Competence comp = new Competence();
                //обходим все дочерние узлы элемента Competence
                foreach (XmlNode childNote in node.ChildNodes)
                {
                    if (childNote.Name == "Code")
                    {
                        comp.Code = childNote.InnerText;
                    }
                    if (childNote.Name == "Name")
                    {
                        comp.Name = childNote.InnerText;
                    }
                }
                arr.Add(comp);
            }


            //StreamReader sr = File.OpenText(filename);
            //while (!sr.EndOfStream)
            //{
            //    String[] fields = sr.ReadLine().Split('|');
            //    if (fields.Length >= 2)
            //    {
            //        Competence comp = new Competence();
            //        comp.Code = fields[0];
            //        comp.Name = fields[1];
            //        arr.Add(comp);
            //    }
            //}
            //sr.Close();
            return arr;
        }
    }
}
