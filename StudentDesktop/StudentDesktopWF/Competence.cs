using System;
using System.Collections;
using System.IO;

namespace vcz.StudentDesktopWF
{
    class Competence
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

        public void Save(ArrayList compArr)
        {
            string filename = "comp.csv";

            if (compArr != null)
            {
                StreamWriter sw = File.CreateText(filename);
                foreach (Competence item in compArr)
                {
                    sw.Write(item.Code);
                    sw.Write("|");
                    sw.WriteLine(item.Name);
                }
                sw.Close();
            }
        }

        public static ArrayList Load()
        {
            ArrayList arr = new ArrayList();

            string filename = "comp.csv";
            StreamReader sr = File.OpenText(filename);
            while (!sr.EndOfStream)
            {
                String[] fields = sr.ReadLine().Split('|');
                if (fields.Length >= 2)
                {
                    Competence comp = new Competence();
                    comp.Code = fields[0];
                    comp.Name = fields[1];
                    arr.Add(comp);
                }
            }
            sr.Close();
            return arr;
        }
    }
}
