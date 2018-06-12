using System;
namespace logicBuilding.Doubly
{
    public class Node {
        public Node Previous { get; set; }
        public object Item { get; set; }
        public Node Next { get; set; }
    }
    public class DoublyLinkedList
    {
       private Node Head;
        private Node Current;
        private static int Count = 0;
        
        public DoublyLinkedList()
        {
            Head = new Node();
            Current = Head;
        }

        public void Additems(object item){
            if (Count == 0)
            {
                Node Newnode = new Node();
                Newnode.Item = item;
                Newnode.Previous = null;
                Head = Newnode;
                Current = Newnode;
                Count++;
              
            }
            else{
                Node Newnode = new Node();
                Newnode.Item = item;
                Current.Next = Newnode;
                Newnode.Previous = Current;
                Current = Newnode;
                Count++;

            }

        }
        public void DisplayList(){
            Node curr = Head;
            while(curr.Next!=null){
              
                Console.WriteLine($"Value: {curr.Item}");
                curr = curr.Next;

            }

        }

        public void SearchAndDelete(object item){
            Node curr = Head; 
            while(curr.Next!=null){
                curr = curr.Next; 
                if(curr.Item == item){
                    curr.Previous.Previous = curr.Next;
                    curr.Next.Previous = curr.Previous.Previous;
                    Count--;
                }
            }
        }
    }
}
