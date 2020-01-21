
namespace FellowshipChaitanya.Data_Structure
{
    using System;

    
    public class Queue
    {
        
        private static int limit = 1000;

       
        private int front, rear, size = 0;

        
        private object[] queue = new object[limit];

     
        public void Enqueue(object data)
        {
            if (!this.IsFull())
            {
                this.queue[this.rear] = data;
                this.rear = (this.rear + 1) % limit;
                this.size++;
            }
        }

        
        public void Show()
        {
            for (int i = 0; i < this.size; i++)
            {
                Console.Write(this.queue[(i + this.front) % limit] + " ");
            }

            Console.WriteLine();
        }

       
        public void Dequeue()
        {
            if (!this.IsEmpty())
            {
                this.size--;
                object value = this.queue[this.front];
                this.front = (this.front + 1) % limit;
            }
        }

        
        public int Size()
        {
            return this.size;
        }

        
        public bool IsEmpty()
        {
            return this.Size() == 0;
        }

      
        public bool IsFull()
        {
            return this.Size() == limit;
        }

       
        public object Get()
        {
            return this.queue[this.front % limit];
        }
    }
}
