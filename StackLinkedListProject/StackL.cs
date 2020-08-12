using System;
using System.Xml;

namespace StackLinkedListProject
{
    class StackL
    {
        private Node top;

        public StackL()
        {
            top = null;
        }

        public int Size()
        {
            int size = 0;
            Node p = top;
            while(p!=null)
            {
                p = p.link;
                size++;
            }
            return size;
        }

        public void Push(int x)
        {
            Node temp = new Node(x);
            temp.link = top;
            top = temp;
        }

        public int Pop()
        {
            int x;
            if (isEmpty())
                throw new System.InvalidOperationException("Stack Underflow");
            x = top.info;
            top = top.link;
            return x;
        }

        public int Peek()
        {
            if(isEmpty())
                throw new System.InvalidOperationException("Stack Underflow");
            return top.info;
        }

        public bool isEmpty()
        {
            return (top == null);
        }

        public void Display()
        {
            Node p = top;
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("Stack is : ");
            while(p!=null)
            {
                Console.WriteLine(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
    }
}
