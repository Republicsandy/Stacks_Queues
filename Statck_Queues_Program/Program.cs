using System;
using System.Collections.Generic;

namespace Statck_Queues_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Stacks and Queues!");
            //creating a list
            Linked_List list = new Linked_List();
            list.Enqueue(56);
            list.Enqueue(30);
            list.Enqueue(70);
            list.Display();
        }
    }
}
