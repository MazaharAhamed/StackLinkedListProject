using System;
using System.Collections.Generic;
using System.Text;

namespace StackLinkedListProject
{
    class Demo
    {
        static void Main(String[] args)
        {
            int choice, x;

            StackL stL = new StackL();

            while(true)
            {
                Console.WriteLine("1.Display Size of stack");
                Console.WriteLine("2.Enter the Element to be Pushed");
                Console.WriteLine("3.Pop an element from the Stack");
                Console.WriteLine("4.Display the top element");
                Console.WriteLine("5.Display all elements");
                Console.WriteLine("6.Quit");
                Console.WriteLine("Enter Your Choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice==6)
                    break;

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("1.Size of the stack is:"+stL.Size());
                        break;
                    case 2:
                        Console.WriteLine("Enter the Element to Push:");
                        x = Convert.ToInt32(Console.ReadLine());
                        stL.Push(x);
                        break;
                    case 3:
                        Console.WriteLine("Popped Element is:");
                        x = Convert.ToInt32(Console.ReadLine());
                        stL.Pop(x);
                        break;
                    case 4:
                        Console.WriteLine("Top Element is:"+stL.Peek());
                        break;
                    case 5:
                        stL.Display();
                        break;
                    default:
                        Console.WriteLine("Wrong Choice:");
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
