using System;
using System.Collections.Generic;

namespace StackUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s1 = new Stack<int>();

            s1.Push(56);
            s1.Push(30);
            s1.Push(70);
            foreach (var ele in s1)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("Aafter---------------");
            while(s1.Count!=0)
            {
                Console.WriteLine(s1.Peek());
                s1.Pop();

            }
        }
    }
}
