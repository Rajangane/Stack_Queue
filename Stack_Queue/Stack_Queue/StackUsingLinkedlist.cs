using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class StackUsingLinkedlist<T>
    {
        private Node<T> top;
        public StackUsingLinkedlist()
        {
            this.top = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = top;
            this.top = node;
            Console.WriteLine("{0} pushed at stack", value);
        }
        public void Display()
        {
            Node<T> temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("\n{0} is at top of the stack ", this.top.data);
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} popped from stack", this.top.data);
            this.top = this.top.next;
        }
        internal void Empty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
