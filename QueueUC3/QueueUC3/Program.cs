﻿using System;
using System.Collections.Generic;

namespace QueueUC3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> s1 = new Queue<int>();

            s1.Enqueue(56);
            s1.Enqueue(30);
            s1.Enqueue(70);
            foreach (var ele in s1)
            {
                Console.WriteLine(ele);
            }
        }
    }
}