namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();


            Console.WriteLine("Select choice from below");
            Console.WriteLine("Stack!!!");
            Console.WriteLine("1. Create stack");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.DisplayStack();
                    break;
                default:
                    Console.WriteLine("Select a proper choice");
                    break;
            }



        }
    }
}