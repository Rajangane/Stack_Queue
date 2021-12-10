// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************* Stack & Queue *****************");
using Stack_Queue;
Console.Write("Select Number:\n1)Stack\n2)Queue\n");
int option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        StackUsingLinkedlist<int> stack = new StackUsingLinkedlist<int>();
        stack.Push(70);
        stack.Push(30);
        stack.Push(56);
        stack.Display();
        stack.Peek();
        stack.Pop();
        stack.Empty();
        break;
    case 2:
        QueueUsingLinkedlist<int> queue = new QueueUsingLinkedlist<int>();
        queue.Enqueue(70);
        queue.Enqueue(30);
        queue.Enqueue(56);
        Console.WriteLine("Before Dequeue : ");
        queue.Display();
        queue.Dequeue();
        Console.WriteLine("\nAfter Dequeue : ");
        queue.Display();
        break;

    default:
        Console.WriteLine("Invalid option");
        break;
}
