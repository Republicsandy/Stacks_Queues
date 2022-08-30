using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statck_Queues_Program
{
    public class Node
    {
        //data is entered
        public int data;
        //Next is the pointer to the next node in the list
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
}
