using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windsor.Project.Interfaces;

namespace Windsor.Project
{
    class Processor
    {
        ILogger logger = null;
        IMessageSender messageSender;
        public Processor()
        {
            logger = IoCUtil.Resolve<ILogger>();
            messageSender =IoCUtil.Resolve<IMessageSender>();
        }
        public void Process()
        {
            logger.WriteLog("Log Text");
            //Ana Uygulama Akışı             
            messageSender.SendMessage("Message Text");
            Console.ReadKey();
        }
    }
}
