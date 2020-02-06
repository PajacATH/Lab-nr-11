using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            var spr = new StreamPliczekReader();
            var people = spr.Read("data.txt");

            var sortedPpl = people.OrderBy(x => x.Nazwisko).ThenBy(x => x.Imie);
            foreach (var item in sortedPpl)
            {
                Console.WriteLine($"{item.Imie} {item.Nazwisko}");
            }
            //Console.WriteLine("dfasghf \r askjdhasrrrrrrrrrrjkdhaskd \r askdjahsdk \r qqqqqqqqq");

            Writer writer = new Writer();
            writer.WczytajDoPliku(sortedPpl.First(), "pliczek.txt");

            writer.WczytajTelefony(sortedPpl.ToList(), "telefony_dzwonią.txt");

            writer.OddzielNumeryTelefonu(sortedPpl.ToList());

            writer.LiteraDlaPliku(sortedPpl.ToList());
        }
    }
}
