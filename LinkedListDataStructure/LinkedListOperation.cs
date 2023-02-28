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
       public void InsertInto( int data , int Position)
        {
            Node node = new Node(data);
            node.data = data;
            node.next = null;
            if(Position < 1)
            {
                Console.WriteLine("Position should be greater than");
            }
            else if(Position == 1)
            {
                node.next = head;
                head= node;
            }
            else
            {
                Node temp = new Node(data);
                temp = head;
                for(int i=1;i<Position-1;i++)
                {
                    if (temp != null)
                    {
                        temp= temp.next;
                    }
                }
                if(temp!= null)
                {
                    node.next = temp.next;
                    temp.next = node;
                }
                else
                {
                    Console.WriteLine("The previous node is null");
                }
            }
        }
        public void Delete()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                head = head.next;
                Console.WriteLine("Removed first node");
            }
        }
        public void Delete_Last_Node()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                if (head.next == null)
                    head = null;
                else
                {
                    Node temp = head;
                    while(temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = null;
                }
            }
        }
        public void Search_Element(int input)
        {
            bool isFound= false;
            if(head == null)
                Console.WriteLine("Linked list is empty");
            else
            {
                Node temp = head;
                while(temp !=null)
                {
                    if(temp.data == input)
                    {
                        isFound = true;
                        Console.WriteLine("Given node {0} is present",input);
                        break;
                    }
                    temp = temp.next;
                }
                if(!isFound)
                {
                    Console.WriteLine("Given node {0} is not present", input);
                }
            }
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
