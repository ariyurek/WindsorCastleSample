using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Windsor.Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor processor = new Processor();
            processor.Process();
        }
    }
}
