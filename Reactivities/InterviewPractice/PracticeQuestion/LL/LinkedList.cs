using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.PracticeQuestion.LL
{
    public class LinkedList
    {
        private Node head;
        private Node tail;
        private int length;

        class Node
        {
            public int value = 0;
            public Node next;
            public Node(int value)
            {
                this.value = value;
            }
        }

        public LinkedList(int Value)
        {
            Node newNode = new Node(Value);
            head = newNode;
            tail = newNode;
            length = 1;
        }
        public void PrintLL()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine("Node" + temp.value);
                temp = temp.next;
            }
            Console.WriteLine("Head:" + head.value);
            Console.WriteLine("Tail:" + tail.value);
            Console.WriteLine("Length:" + length);
        }
        public void Append(int value)
        {
            Node add = new Node(value);
            if (length == 0)
            {
                head = add;
                tail = add;
            }
            else
            {
                tail.next = add;
                tail = add;
            }
            length++;
        }
    }
}
