using System;
namespace logicBuilding
{
    public class QueueNode
    {

        public QueueNode Next { get; set; }
        public object Item { get; set; }
    }
    public class QueueLinkedList
    {
        private QueueNode Head;
        private QueueNode Current;
        private static int _count = 0;
        public QueueLinkedList()
        {
            Head = new QueueNode();
            Current = Head;
        }
        public bool isEmpty(){
            return _count == 0;
        }
        public int Count(){
            return _count;
        }
        public void Enqueue(object item)
        {
            if (_count == 0)
            {
                QueueNode newnode = new QueueNode();
                newnode.Item = item;
                Head.Next = newnode;
                Current = newnode;
                _count++;
              
            }
            else{
                QueueNode newnode = new QueueNode();
                newnode.Item = item;
                Current.Next = newnode;
                Current = newnode;
                _count++;
            }

        }
        public bool Dequeue()
        {
            if(isEmpty()){
                Console.WriteLine("Queue is empty");
                return false;
            }
            else{
                Head = Head.Next;
                _count--;
                return true;
            }
        }
        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("No elements to display");

            }
            else
            {
                QueueNode curr = Head;
                while (curr.Next != null)
                {
                    curr = curr.Next;
                    Console.Write($"->{curr.Item}");
                }
                Console.WriteLine();
            }
        }
    }
}