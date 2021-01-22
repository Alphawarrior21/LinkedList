using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class CircularLinkedList : LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public override void Display()
        {
            Node n = Head;
            Node p = Tail;
            StringBuilder stringBuilder = new StringBuilder();
            while (p.Next!=n)
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

        public override void InsertNewNodeAtEndOfLinkedList(Node newNode)
        {
            newNode.Next = null;
            /***Check if linkedList is empty***/
            if(Head==null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            Tail.Next = newNode;
            Tail = newNode;
            Tail.Next = Head;
                

        }

        public override void InsertNewNodeAtFrontOfLinkedList(Node newNode)
        {
            newNode.Next = null;
            /***Check if linkedList is empty***/
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            Head.Next = newNode;
            Head = newNode;
            Tail.Next = Head;

        }
    }
}
