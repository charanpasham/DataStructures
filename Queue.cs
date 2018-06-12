using System;
namespace logicBuilding
{
    public class Queue
    {
        const int MAX = 1000; 
        int[] queueArray = new int[MAX];
        int top;
        int bottom; 
        public Queue()
        {
            top = -1;
            bottom = 0;
        }
        public bool Enqueue(int item){
            if(top>MAX)
            {
                Console.WriteLine("Stack overflowed");
                return false;
            }
            else{
                queueArray[++top] = item;
                return true;
            }
     
        }
        public bool Dequeue(){
            if (top < bottom)
            {
                Console.WriteLine("No elements to remove");
                return false;
            }
            else
            {

                int DequeuedValue = queueArray[bottom++];
                Console.WriteLine($"Value Dequeued{DequeuedValue}");

                return true;
            }
        }

        public void DisplayQueue(){
            for (int i = bottom; i <= top; i++){
                Console.WriteLine($"Queue: {queueArray[i]}");
            }
        }
    }
}
