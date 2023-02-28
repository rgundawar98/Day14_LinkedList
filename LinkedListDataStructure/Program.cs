using System;

namespace LinkedListDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Data Structures Linked List");
            LinkedListOperation  Operation = new LinkedListOperation();
            // Operation.Insert(56);  //UC1 Insert element into linkedlist
            //Operation.Insert(30);
            //Operation.AddElement(70); //UC2 Add element into linked list
            //Operation.AddElement(30);
            //Operation.AddElement(56);
            //Operation.Append(56); //UC3 Append element
            //Operation.Append(30);
            //Operation.Append(70);

            //UC4 InsertInto method
            //Operation.AddElement(56);
            //Operation.AddElement(70);
            //Operation.InsertInto(30,2);
            //Operation.Display();

            //UC5 Delete method
            //Operation.AddElement(56);
            //Operation.AddElement(70);
            //Operation.InsertInto(30,2);
            //Operation.Delete();
            //Operation.Display();

            //UC6 Delete last node
            Operation.AddElement(56);
            Operation.AddElement(70);
            Operation.InsertInto(30, 2);
            Operation.Delete_Last_Node();
            Operation.Display();
        }
    }
}
