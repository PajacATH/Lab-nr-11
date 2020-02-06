using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Lab11
{
    class Reader : IReader
    {
        public List<Person> Read(string file)
        {
            string[] data = File.ReadAllLines(file);
            var ppl = data.Select(x => CSVStringToPersonConverter.Convert(x) );

            return ppl.ToList();
        }
    }
}
