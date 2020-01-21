

namespace FellowshipChaitanya.Data_Structure
{
    using System;
    using System.Collections;
    using System.Text;

   
    public class QueueUsingLinkedList
    {
        
        private Node head;

        private int size = 0;

        
        public bool IsEmpty()
        {
            return this.size == 0;
        }

       
        public void Enqueue(object data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node tempNode = this.head;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }

                tempNode.next = node;
            }

            this.size++;
        }

       
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is already empty");
                return;
            }
            else
            {
                this.head = this.head.next;
            }

            this.size--;
        }

       
        public void Show()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node tempNode = this.head;
                while (tempNode != null)
                {
                    Console.Write(tempNode.data + " ");
                    tempNode = tempNode.next;
                }

                Console.WriteLine();
            }
        }

      
        public int Size()
        {
            return this.size;
        }

        public object Get()
        {
            return this.head.data;
        }
    }
}
