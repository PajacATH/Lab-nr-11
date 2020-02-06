using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    public class Person
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Telefon { get; set; }
        public Person(int iD, string name, string lastName, string phone)
        {
            ID = iD;
            Imie = name;
            Nazwisko = lastName;
            Telefon = phone;
        }
    }
}
