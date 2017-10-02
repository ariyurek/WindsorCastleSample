using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windsor.Project.Interfaces;

namespace Windsor.Project.MessageSenders
{
    class MailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(String.Format("MailSender : {0}", message));
        }
    }
}
