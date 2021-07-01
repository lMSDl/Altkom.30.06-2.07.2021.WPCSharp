﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Decorator
{
    public class Notification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Internal notification has been send: " + message);
        }
    }
}
