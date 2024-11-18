using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.PracticeQuestion.LL
{
    public class CustomLinkedList
    {
        //Head
        //Tail
        //Node - value and next]

        Node Head;
        Node Tail;
        int length;
        private int v;

        class Node
        {
            int value = 0;
            Node next;
            public Node(int value)
            {
                this.value = value;      
            }
        }
      
        public CustomLinkedList(int Value)
        {
          Node newNode=new Node(Value);
            Head = newNode;
            Tail = newNode;
            length = 1;
        }

    }
}
