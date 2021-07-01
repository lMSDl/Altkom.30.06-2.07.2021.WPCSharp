﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Decorator
{
    public interface INotification
    {
        void Send(string message);
    }
}
