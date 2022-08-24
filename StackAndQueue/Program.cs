namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            var queue = new Queue();

            Console.WriteLine("Select choice from below");
            Console.WriteLine("Stack!!!");
            Console.WriteLine("1. Create stack");
            Console.WriteLine("2. Empty stack -- Peek and then Pop");
            Console.WriteLine("Queue!!!");
            Console.WriteLine("3. Create a queue");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.DisplayStack();
                    break;
                case 2:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.DisplayStack();
                    stack.EmptyStack();         // this will empty stack one by one element
                    stack.DisplayStack();
                    break;
                case 3:
                    queue.EnQueue(56);
                    queue.EnQueue(30);
                    queue.EnQueue(70);
                    queue.ShowQueue();
                    break;
                default:
                    Console.WriteLine("Select a proper choice");
                    break;
            }



        }
    }
}