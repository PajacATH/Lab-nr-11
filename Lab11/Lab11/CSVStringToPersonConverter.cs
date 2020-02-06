using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab11
{
    public class CSVStringToPersonConverter
    {
        static public Person Convert(string csvstring)
        {
            string[] line = csvstring.Split(';');
            return new Person(System.Convert.ToInt32(line[0]), line[1], line[2], line[3]);
        }
    }
}
