﻿using System;

namespace DIP
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to Console: { message }");
        }
    }
}