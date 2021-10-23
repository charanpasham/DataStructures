using System;
using System.Collections.Generic;
using logicBuilding.StackProblems;

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

            var list = new LinkedList<int>();
            list.Add(3);
            list.Add(5);
            list.Add(10);
            list.Add(20);
     
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count of numbers" + list.Count());

            var listString = new LinkedList<string>();
            listString.Add("Apples");
            listString.Add("Oranges");
            listString.Add("Bananas");
            listString.Add("Grapes");
            foreach(var itemString in listString)
            {
                Console.WriteLine(itemString);
            }

            Console.WriteLine("Count of fruites" + listString.Count());
        }
    }

}
