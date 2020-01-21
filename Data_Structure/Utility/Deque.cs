using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya.Data_Structure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    
    public class Deque
    {
       
        private Node head;

       
        public void AddFront(object data)
        {
            Node node = new Node();
            node.data = data;
            if (this.head == null)
            {
                this.head = node;
                node.next = null;
            }
            else
            {
                Node tempNode = this.head;
                this.head = node;
                node.next = tempNode;
            }
        }

       
        public void AddRear(object data)
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
        }

        
        public object RemoveFront()
        {
            if (this.head == null)
            {
                return null;
            }
            else
            {
                Node tempNode = this.head;
                this.head = this.head.next;
                return tempNode.data;
            }
        }

        
        public object RemoveRear()
        {
            if (this.head == null)
            {
                return null;
            }
            else if (this.head.next == null)
            {
                Node tempNode = this.head;
                this.head = null;
                return tempNode.data;
            }
            else
            {
                Node tempNode = this.head;
                while (tempNode.next.next != null)
                {
                    tempNode = tempNode.next;
                }

                Node tempNode1 = tempNode;
                tempNode.next = null;
                return tempNode1.data;
            }
        }

      
        public int Size()
        {
            int count = 0;
            if (this.head == null)
            {
                return count;
            }
            else
            {
                Node node = this.head;
                while (node != null)
                {
                    count++;
                    node = node.next;
                }

                return count;
            }
        }

       
        public bool IsEmpty()
        {
            return this.Size() == 0;
        }
    }

}
