﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Services
{
    public class Greetings : IGreetings
    {
        public string Greet(string name)
        { 
            return $"Hello {name}";
        }
    }
}
