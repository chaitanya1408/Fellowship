

namespace FellowshipChaitanya.Data_Structure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    
    public class LinkedList
    {
        
        private Node head;

       
        public LinkedList List()
        {
            return new LinkedList();
        }

        
        public void Append(object data)
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

        
        public void Show()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node node = this.head;
                while (node != null)
                {
                    Console.Write(node.data + " ");
                    node = node.next;
                }
            }
        }

        
        public void Add(object data)
        {
            Node node = new Node();
            node.data = data;
            if (this.head == null)
            {
                this.head = node;
                this.head.next = null;
            }
            else
            {
                Node tempNode = this.head;
                this.head = node;
                this.head.next = tempNode;
            }
        }

        
        public void Shift()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                this.head = this.head.next;
            }
        }

        
        public object Pop()
        {
            Node tempNodeOne = this.head;
            Node tempNodeTwo = this.head;
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
            }
            else if (this.head.next == null)
            {
                this.head = null;
                return tempNodeOne.data;
            }
            else
            {
                while (tempNodeOne.next.next != null)
                {
                    tempNodeOne = tempNodeOne.next;
                }

                tempNodeTwo = tempNodeOne.next;
                tempNodeOne.next = null;
            }

            return tempNodeTwo.data;
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
                Node tempNode = this.head;
                while (tempNode != null)
                {
                    count++;
                    tempNode = tempNode.next;
                }

                return count;
            }
        }

       
        public void Insert(int index, object data)
        {
            Node node = new Node();
            node.data = data;
            if (this.head == null)
            {
                this.head = node;
                this.head.next = null;
            }
            else if (index == 0)
            {
                Node tempNodeOne = this.head;
                this.head = node;
                this.head.next = tempNodeOne;
            }
            else
            {
                Node tempNodeOne = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    tempNodeOne = tempNodeOne.next;
                    if (tempNodeOne.next == null)
                    {
                        Node tempNodeThree = tempNodeOne.next;
                        tempNodeOne.next = node;
                        node.next = tempNodeThree;
                        return;
                    }
                }

                Node tempNodeTwo = tempNodeOne.next;
                tempNodeOne.next = node;
                node.next = tempNodeTwo;
            }
        }

        
        public object Pop(int index)
        {
            Node node = this.head;
            Node tempNodeOne = this.head;
            if (index == 0)
            {
                this.head = this.head.next;
                return node.data;
            }

            if (index >= this.Size())
            {
                return this.Pop();
            }

            for (int i = 0; i < index - 1; i++)
            {
                node = node.next;
            }

            Node tempNodeTwo = node;
            tempNodeOne = node.next;
            node.next = tempNodeTwo.next.next;
            return tempNodeOne.data;
        }

       
        public void Remove(object data)
        {
            Node tempNode = this.head, prev = null;
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                if (tempNode != null && tempNode.data + string.Empty == data + string.Empty)
                {
                    this.head = tempNode.next;
                    return;
                }

                while (tempNode != null && tempNode.data + string.Empty != data + string.Empty)
                {
                    prev = tempNode;
                    tempNode = tempNode.next;
                }

                if (tempNode == null)
                {
                    return;
                }

                prev.next = tempNode.next;
            }
        }

       
        public bool Search(object data)
        {
            if (this.head == null)
            {
                return false;
            }

            Node tempNode = this.head;
            while (tempNode != null)
            {
                if (tempNode.data + string.Empty == data + string.Empty)
                {
                    return true;
                }

                tempNode = tempNode.next;
            }

            return false;
        }

      
        public bool IsEmpty()
        {
            if (this.head == null)
            {
                return true;
            }

            return false;
        }

       
        public int Index(object data)
        {
            int find = 0;
            Node tempNode = this.head;
            while (tempNode != null && tempNode.data + string.Empty != data + string.Empty)
            {
                tempNode = tempNode.next;
                find++;
            }

            if (tempNode == null)
            {
                return -1;
            }

            return find;
        }

      
        public object Get(int index)
        {
            Node tempNode = this.head;
            if (this.head == null)
            {
                return null;
            }
            else if (index == 0)
            {
                return tempNode.data;
            }
            else
            {
                if (index >= this.Size())
                {
                    return null;
                }

                for (int i = 0; i < index - 1; i++)
                {
                    tempNode = tempNode.next;
                }

                tempNode = tempNode.next;
                return tempNode.data;
            }
        }

       
        public void Put(int index, object data)
        {
            Node node = new Node();
            node.data = data;
            if (this.head.next == null)
            {
                this.head = node;
                node.next = null;
            }
            else if (index == 0)
            {
                Node tempNode = this.head.next;
                this.head = node;
                node.next = tempNode;
            }
            else if (index == 1)
            {
                Node tempNode = this.head.next.next;
                this.head.next = node;
                node.next = tempNode;
            }
            else
            {
                Node tempNodeOne = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    tempNodeOne = tempNodeOne.next;
                }

                Node tempNodeTwo = tempNodeOne.next.next;
                tempNodeOne.next = node;
                node.next = tempNodeTwo;
            }
        }

      
        public void AddOrder(object data)
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
                Node tempNodeOne = this.head;
                while (tempNodeOne.next != null && Convert.ToInt32(tempNodeOne.next.data) < Convert.ToInt32(data))
                {
                    tempNodeOne = tempNodeOne.next;
                }

                Node tempNodeTwo = tempNodeOne.next;
                tempNodeOne.next = node;
                node.next = tempNodeTwo;
            }
        }

       
        public void OrederLinkedList()
        {
            if (this.Size() < 2)
            {
                return;
            }
            else
            {
                for (int i = 0; i < this.Size(); i++)
                {
                    for (int j = 0; j < this.Size() - 1; j++)
                    {
                        if (Convert.ToInt32(this.Get(j)) > Convert.ToInt32(this.Get(j + 1)))
                        {
                            int temp = Convert.ToInt32(this.Get(j));
                            this.Put(j, this.Get(j + 1));
                            this.Put(j + 1, temp);
                        }
                    }
                }
            }
        }
    }
}
