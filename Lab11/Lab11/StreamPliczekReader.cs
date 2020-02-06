using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Lab11
{
    class StreamPliczekReader : IReader
    {
        public List<Person> Read(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string data = sr.ReadToEnd();
            string[] lines = data.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var ppl = lines.Select(x => CSVStringToPersonConverter.Convert(x) );

            return ppl.ToList();

        }

    }
}
