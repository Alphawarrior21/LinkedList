using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public abstract class LinkedList
    {
       
        public abstract void Display();
        public abstract void InsertNewNodeAtFrontOfLinkedList(Node newNode);
        public abstract void InsertNewNodeAtEndOfLinkedList(Node newNode);
    }
   public class SingleLinkedList : LinkedList
    {
        public Node Head { get; set; }
        public override void Display()
        {
            Node n = Head;
            StringBuilder stringBuilder = new StringBuilder();
            while (n.Next != null)
            {
                if (n.Data.GetType() == typeof(SubDataFirst))
                {
                    var d = (SubDataFirst)n.Data;
                    stringBuilder.Append(d.Name + "/" + d.RollNumber + "-->");
                    n = n.Next;
                    if (n.Next == null)
                    {
                        var nextnode = (SubDataFirst)n.Data;
                        stringBuilder.Append(nextnode.Name + "/" + nextnode.RollNumber);

                    }
                        
                }

            }
         
            Console.WriteLine(stringBuilder);
        }

        public override void InsertNewNodeAtFrontOfLinkedList(Node newNode)
        {
            newNode.Next = this.Head;
            this.Head = newNode;
            Console.WriteLine("New Node Added at the front ");
        }
        public override void InsertNewNodeAtEndOfLinkedList(Node newNode)
        {
            Node n = Head;
            newNode.Next = null;
            if(n==null)
            {
                Console.WriteLine("LinkedList was empty :: Adding a new node");
                newNode.Next = null;
                Head = n;
                return;
            }

            while (n.Next != null)
            {
                n = n.Next;
            }
            n.Next = newNode;


            Console.WriteLine("New Node Added at the end ");
        }
    }
    public class Node
    {
       public object Data { get; set; }
       public Node Next { get; set; }
       public Node(object data)
        {
            Data = data ?? throw new ArgumentNullException("Argument value :: " + data);
            Next = null;
        }
    }
}
