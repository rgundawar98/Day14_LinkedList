using System;

namespace LinkedListDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Data Structures Linked List");
            LinkedListOperation  Operation = new LinkedListOperation();
            Operation.Insert(56);  //UC1 Insert element into linkedlist
            Operation.Insert(30);
            Operation.Insert(70);
        }
    }
}
