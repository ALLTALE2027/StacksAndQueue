using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Queue
    {
        private Node Front;
        private Node Rear;
        int size = 0;

        public void EnQueue(int data)
        {
            Node node = new Node(data);
            if (Front == null && Rear == null)
            {
                Front = node;
                Rear = node;
            }
            else
            {
                Rear.next = node;
                Rear = node;
            }
            size++;
            Console.WriteLine("Element is added to queue");
        }

        public void DeQueue()
        {
            int value = Front.data;
            Front = Front.next;

            if (Front == null)
                Rear = null;

            size--;
            Console.WriteLine("Element with data {0} is removed from queue ", value);
        }

        public void ShowQueue()
        {
            Node temp = Front;
            if (temp == null)
                Console.WriteLine("Queue is empty");
            else
            {
                Console.WriteLine("Queue elements");
                while (temp != null)
                {
                    Console.Write(temp.data);
                    if (temp.next != null)
                        Console.Write("<-");
                    temp = temp.next;
                }
                Console.WriteLine();
                Console.WriteLine("Queue length is: " + size);
                Console.WriteLine();
            }
        }
    }
}

