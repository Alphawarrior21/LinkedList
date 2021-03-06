﻿using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d1 = new SubDataFirst(123, "FirstNode");
            Data d2 = new SubDataFirst(456, "SecondNode");
            Data d3 = new SubDataFirst(789, "ThirdNode");
            Data d4 = new SubDataFirst(56, "FourthNewNode");
            Data d5 = new SubDataFirst(57, "FifthNewNode");


            Node First_Node = new Node(d1);
            Node Second_Node = new Node(d2);
            Node Third_Node = new Node(d3);
            Node Fourth_Node = new Node(d4);
            Node Fifth_Node = new Node(d5);

            /*************Single Linked List***************/

            SingleLinkedList singleLinkedList = new SingleLinkedList();
            singleLinkedList.Head = First_Node; /*Setting the first node*/
            singleLinkedList.Head.Next = Second_Node;
            Second_Node.Next = Third_Node;
            Third_Node.Next = null;

            singleLinkedList.Display();
            singleLinkedList.InsertNewNodeAtFrontOfLinkedList(Fourth_Node);
            singleLinkedList.Display();
            singleLinkedList.InsertNewNodeAtEndOfLinkedList(Fifth_Node);
            singleLinkedList.Display();

            /*************Circular Linked List***************/
            CircularLinkedList circularLinkedList = new CircularLinkedList();
            circularLinkedList.InsertNewNodeAtFrontOfLinkedList(First_Node);
            circularLinkedList.InsertNewNodeAtFrontOfLinkedList(Second_Node);
            circularLinkedList.InsertNewNodeAtFrontOfLinkedList(Third_Node);
            circularLinkedList.InsertNewNodeAtFrontOfLinkedList(Fourth_Node);
            circularLinkedList.InsertNewNodeAtFrontOfLinkedList(Fifth_Node);
            circularLinkedList.Display();

        }
    }
}
