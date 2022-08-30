using System;
using System.Collections.Generic;

namespace Statck_Queues_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Stacks and Queues!");
            //creation of a list
            Linked_List list = new Linked_List();
            //pushing elements to list
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();
        }
    }
}
