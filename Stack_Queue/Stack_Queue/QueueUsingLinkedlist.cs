using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class QueueUsingLinkedlist<T>
    {
        Node<T> head = null;
        /// <summary>
        /// Add Method
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
                head = node;
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} added", node.data);
        }
        
        /// <summary>
        /// Display Method
        /// </summary>
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        /// <summary>
        /// Dequeue Method
        /// </summary>
        /// <returns></returns>
        internal Node<T> Dequeue()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }

    }
}
