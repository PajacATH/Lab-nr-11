using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    interface IReader
    {
        List<Person> Read(string fileName);
    }
}
