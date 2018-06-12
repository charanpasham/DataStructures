using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using logicBuilding.Doubly;
using Microsoft.


namespace logicBuilding
{

    class MyStack
    {
        private List<int> stackList { get; set; }
        public MyStack()
        {
            stackList = new List<int>(); 
        }

        public void Push(int item){
            stackList.Add(item); 
        }
        public int Pop(){
            int removedValue = stackList[stackList.Count - 1];
            stackList.RemoveAt(stackList.Count - 1);
            return removedValue;
        }
        public void Display(){
            foreach(int value in stackList){
                Console.WriteLine($"{value}");
            }
        }

    }

    class MyStackWithArray{
        const int MAX = 1000; 
        private int[] StackArray = new int[MAX];
        int top; 
        public MyStackWithArray(){
            top = -1;
        }
        public bool Push(int item){
            if (top > MAX)
            {
                Console.WriteLine("Stack OverFlowed");
                return false;
            }
            else
            {
                StackArray[++top] = item;
                return true;
            }
        }
        public bool Pop(){
            if(top<0){
                Console.WriteLine("No elements to POP");
                return false;
            }
            else{
                int value = StackArray[top--];
            Console.WriteLine($"Popped:{value}");
                return true;
            }
          
        }

        public void displayStackArray(){
            for (int i = 0; i <=top; i++){
                Console.WriteLine($"value of stack: {StackArray[i]}");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            //QueueLinkedList list = new QueueLinkedList();

            //Console.WriteLine("Choose you choice:");
            //int key;
            //do
            //{
            //    Console.WriteLine("1.Enqueue\n2.Dequeue\n3.Display\n4.TotalCount\n5.Quit");
            // key = Convert.ToInt32(Console.ReadLine());
            //    switch (key)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter Queue element");



            //            int element = Convert.ToInt32(Console.ReadLine());
            //            list.Enqueue(element);

            //            break;
            //        case 2:
            //            list.Dequeue();
            //            break;
            //        case 3:
            //            list.Display();
            //            break;
            //        case 4: list.Count();
            //            break;
            //    }
            //} while (key != 5);

            LinkedList list = new LinkedList();
            list.AddAtFirst(100);
            list.AddAtLast(200);
            list.AddAtFirst(430);
            list.AddAtLast(1000);
            list.AddAtIndex(2000, 3);
            list.Traverse();
            list.Reverse();

        
            list.Traverse();
      
       
    



            //list.Additems("Hello");
            //list.Additems("Charan");
            //list.Additems("Reddy");
            //list.TotalCount();

            //list.Traverse();

            //list.SearchAndDelete("Reddy");
            //list.SearchAndDelete(30);
            //list.SearchAndDelete(150);
            //list.SearchAndDelete(20);
            //list.SearchAndDelete(1);

            //list.TotalCount();
            //list.Traverse();



        }
    }

}
