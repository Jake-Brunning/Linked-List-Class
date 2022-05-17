using System;
namespace Linked_List_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] data = new object[] { 1, 2, 3, 4, 5 };

            LinkedList linkedList = new LinkedList(data);
            linkedList.Next();
            Console.WriteLine(linkedList.GetCurrent());
            linkedList.Add("hello");

        }
    }

    class LinkedList
    {
        Node current = new Node();
        
        public LinkedList(object[] data)
        {
            Node LastNode = new Node();
            for (int i = 0; i < data.Length; i++) 
            {
                Node BeingAdded = new Node();
                if(i == 0)
                {
                    current.data = data[i];
                    LastNode = current;
                    continue;
                }           
                
                BeingAdded.data = data[i];
                LastNode.head = BeingAdded;
                LastNode = BeingAdded;
            }          
        }

        public object GetCurrent()
        {
            return current.data;
        }
        public void Next()
        {
            current = current.head;
        }

        public void Add(object Data)
        {
            Node tempNode = new Node { data = current.data, head = current.head };

            while(tempNode.head != null)
            {
                tempNode = tempNode.head;
            }

            tempNode.head = new Node { data = Data };
        }

        class Node
        {
            public object data { get; set; }
            public Node head { get; set; }        
        }
    }
    
}
