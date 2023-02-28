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
            //Operation.AddElement(56);
            //Operation.AddElement(70);
            //Operation.InsertInto(30, 2);
            //Operation.Delete_Last_Node();
            //Operation.Display();

            //UC7 SearchElement in linkedlist
            //Operation.AddElement(56);
            //Operation.AddElement(70);
            //Operation.InsertInto(30, 2);
            //Operation.Display();
            //Operation.Search_Element(30);

            //UC8 Insert_new_element
            //Operation.AddElement(56);
            //Operation.AddElement(70);
            //Operation.InsertInto(30,2);
            //Operation.Insert_New_Element(40,30);
            //Operation.Display();

            //UC9 PopAnyElement
            Operation.AddElement(56);
            Operation.AddElement(70);
            Operation.InsertInto(30, 2);
            Operation.Insert_New_Element(40, 30);
            Operation.Display();
            Operation.Pop_Any_Element(40);
        }
    }
}
