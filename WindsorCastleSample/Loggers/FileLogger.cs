using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windsor.Project.Interfaces;

namespace Windsor.Project.Loggers
{
    class FileLogger : ILogger 
    { 
        public void WriteLog(string message) 
        { 
            Console.WriteLine(String.Format("FileLogger : {0}", message)); 
        } 
    }
}
