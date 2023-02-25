using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    public class LinkedListOperation
    {
        public Node head;
        public void Insert(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
                Console.WriteLine("{0} is inserted into linked list",node.data);
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("{0} is inserted into linked list",node.data);
            }
        }
    }
}
