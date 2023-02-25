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
        public void AddElement(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }
        public void Append(int data) //UC3 Append Data
        {
            Insert(data);
        }
        public void Display()
        {
            if(head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                Node temp = head;
                while(temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
