using System;
namespace logicBuilding
{

    //Create a list node.
    //With value store and next element address reference.
    public class Node
    {
        public object item { get; set; }
        public Node next{ get; set; }
    }

    /*Operation of a linked list. 
        *Add items.
        *Delete items. 
        *Total Count. 


     */
    public class LinkedList
    {
        private static int count = 0; 
        Node Head;
        private Node currentNode;
         


        public LinkedList()
        {
            Head = new Node();
            currentNode = new Node();
        }

        public bool isEmpty(){
            return count == 0;
        }
        public void AddAtFirst(object item){

            if (count == 0)
            {
                Head = new Node();
                Head.item = item;
                currentNode.next = Head;
                currentNode = Head;
                count++;
            }
            else
            {
                Node newNode = new Node();
                newNode.item = item;
                newNode.next = Head.next;
                Head.next = newNode;
                count++;

                if (count == 1)
                {
                    currentNode.next = newNode;
                    currentNode = newNode;
                }
            }

        }
        public void AddAtLast(object item){
            Node node = new Node();
            node.item = item;
            currentNode.next = node;
            currentNode = node;
            //Node curr = Head; 
            //while(curr.next!=null){
            //    curr = curr.next; 
            //}
            //curr.next = node;
             
            count++;
        }
        public void AddAtIndex(object item, int index){
            Node curr = Head; 
            for (int i = 0; i < index; i++){
                curr = curr.next;
            }
            Node node = new Node();
            node.item = item;
            node.next = curr.next;
            curr.next = node;
            count++;
        }
        public void Reverse(){
            Node curr = Head;
            Node next = null;
            Node prev = null; 
            while(curr.next!=null){
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            curr.next = prev;
            Head = curr;

          curr = Head; 
            while(curr.next!=null){
                curr = curr.next; 

            }
            currentNode = curr;

        }

        //public void Additems(object item){
        //    if(count == 0){
        //        Node MyNode = new Node(); //Create a new node;
        //        MyNode.item = item; //Insert element into new node;
        //        Head.next = MyNode;
        //        Current.next = MyNode;
        //        Current = MyNode;
        //        count++;
        //    }
        //    else{
        //        Node MyNode = new Node(); //Create a new node;
        //        MyNode.item = item; //Insert element into new node;
        //        Current.next = MyNode;
        //        Current = MyNode;
        //        count++;
        //    }
        //}

        public void Traverse(){
            Node curr = Head;
            Console.Write("Head ->");
            while(curr.next!=null)
            {
                Console.Write(curr.item);
                curr = curr.next;

          

                Console.Write("->");
            } 
            Console.WriteLine();
        }
        public void Remove(object item){

            Console.WriteLine($"Deleting {item} from list.....");
            Node curr = Head;
            Node prev;
            int flag = 0;
            while(curr.next!=null){
                prev = curr;
                curr = curr.next;
                if(curr.item.Equals(item)){
                    //undergo delete operation
                    prev.next = curr.next;
                    count--;
                    flag = 1;
                }
               
            }
            if(flag == 0){
              Console.WriteLine($"{item} is not found in the list.");
            }
        }
        public void TotalCount(){
            Console.WriteLine($"Number of elements in the list are:{count}");
        }

        public void RemoveAt(int position){
            Node curr = Head;
            Node prev = Head;
            for (int i = 0; i < position; i++){
                prev = curr;  
                    curr = curr.next;
                    
            }

            prev.next = curr.next;
        }


    }
}
