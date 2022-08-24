using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{    
    internal class Stack
    {
        private Node Top;
        private int size = 0;


        public void Push(int data)  
        {
            Node node = new Node(data);
            if (Top == null)
            {
                Top = node;
            }
            else
            {
                node.next = Top;
                Top = node;
            }
            size++;
            Console.WriteLine("Element is Pushed");
        }

        public void Pop()
        {
            if (Top == null)
            {
                Console.WriteLine("Stack is empty, can not pop");
                return;
            }
            int value = Top.data;
            Top = Top.next;
            size--;
            Console.WriteLine("Element with data {0} is pop-ed", value);
        }

        public void EmptyStack()  // this methods peeks and pops until stack is empty
        {
            Node temp=Top;
            while (temp != null)
            {
                Peek();
                Pop();
                temp=temp.next;
            }
        }
        public void Peek()
        {
            if (Top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            int value = Top.data;
            Console.WriteLine("Element on top is: " + value);
        }

        public void DisplayStack()
        {
            Node temp = Top;
            if (temp == null)
                Console.WriteLine("Stack is empty");
            else
            {
                Console.WriteLine("Stack contents");
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    if (temp.next != null)
                        Console.WriteLine("|");
                    temp = temp.next;
                }

                Console.WriteLine();
                Console.WriteLine("Stack height is: " + size);
                Console.WriteLine();
            }
        }
    }
}
