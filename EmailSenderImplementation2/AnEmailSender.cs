﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderImplementation2
{
    public class AnEmailSender : EmailSenderInterfaces.IEmailSender
    {
        public bool SendEmail(string to, string body)
        {
            Console.WriteLine("Sending mail using implementation 2 to:\n\"{0}\"\n with body:\n\"{1}\"\n", to, body);
            return true;
        }
    }
}
