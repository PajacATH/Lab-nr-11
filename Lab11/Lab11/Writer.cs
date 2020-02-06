using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Lab11
{
    class Writer
    {
        public void WczytajDoPliku(Person person, string file)
        {
            StreamWriter sw = new StreamWriter(file, true);

            sw.Write($"[{person.ID}] {person.Imie} {person.Nazwisko} {person.Telefon}");
            sw.Close();
        }

        public void WczytajTelefony(List<Person> person, string file)
        {
            StreamWriter sw = new StreamWriter(file, false);

            foreach (var item in person)
            {
                sw.WriteLine($"{item.Telefon}");
            }

            sw.Close();
        }

        public void OddzielNumeryTelefonu(List<Person> person)
        {
            string file = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                file = "data\\" + i.ToString() + ".txt";

                StreamWriter sw = new StreamWriter(file, false);
                var telefony = person.Skip(i * 10).Take(10);

                foreach (var item in telefony)
                {
                    sw.WriteLine($"{item.Telefon}");
                }
                sw.Close();
            }
        }

        public void LiteraDlaPliku(List<Person> person)
        {
            string file = string.Empty;
            var znak = person.Select(x => x.Imie[0]).OrderBy(x => x).Distinct();
            foreach (var item in znak)
            {
                file = "literki\\" + item.ToString() + ".txt";

                StreamWriter sw = new StreamWriter(file, false);
                var data = person.Where(x => x.Imie[0] == item);

                foreach (var x in data)
                {
                    sw.WriteLine($"[{x.ID}] {x.Imie} {x.Nazwisko} {x.Telefon}");
                }
                sw.Close();
            }
        }
    }
}
