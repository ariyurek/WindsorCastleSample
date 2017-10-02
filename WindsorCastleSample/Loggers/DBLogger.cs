using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windsor.Project.Interfaces;

namespace Windsor.Project.Loggers
{
    class DBLogger : ILogger
    { 
        public void WriteLog(string message) 
        { 
            Console.WriteLine(String.Format("DBLogger : {0}", message)); 
        } 
    }
}
