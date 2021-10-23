using System;
using System.Collections;
using System.Collections.Generic;

namespace logicBuilding
{

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }

    public class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> Current = null;
        public Node<T> Head = null;
        public LinkedList()
        {
            Current = Head;
        }


        public void Add(T item)
        {
            // 5 -> 4 -> 3 -> null
            if(Head == null)
            {
                Head = Current = new Node<T>();
                Current.Value = item;
            } else
            {
                Current.Next = new Node<T>();
                Current = Current.Next;
                Current.Value = item;
            }
        }



        public int Count()
        {
            Current = Head;
            var count = 0;
            while(Current != null)
            {
                count += 1;
                Current = Current.Next;
            }
            return count;
        }


        //public void Remove(T item)
        //{

        //    Head = root;
        //    Node prev = null;

        //    if (Head.Value.Equals(item))
        //    {
        //        root = Head.Next;
        //        Head = root;
        //        return;
        //    }
        //    else
        //    {
        //        while(Head != null)
        //        {
        //            foreach()

        //        }
        //    }
        //}



        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }



        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator<T>(this);
        }

        // Only private getEnumerator is defined in IEnumerable.
        // But in essense, even if a class has any public GetEnumerator method (without having to extend IEnumerable), it will be called from foreach.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

    public struct Enumerator<T> : IEnumerator<T>
    {
        private LinkedList<T> myList;
        private Node<T> myNode;
        private int index;
        private T current;
        public Enumerator(LinkedList<T> list)
        {
            myList = list;
            myNode = list.Head;
            current = default(T);
            index = 0;
        }


        public T Current
        {
            get { return current; }
        }

        object IEnumerator.Current
        {
            get
            {
                if (index == 0 || (index == myList.Count() + 1))
                {
                    throw new InvalidOperationException();
                }

                return Current;
            }
        }


        public void Dispose()
        {
        }

        public bool MoveNext()
        {

            if(myNode == null)
            {
                index = myList.Count() + 1;
                return false;
            }
            index++;
            current = myNode.Value;
            myNode = myNode.Next;
            if(myNode == myList.Head)
            {
                myNode = null;
            }
            return true;
        }

        public void Reset()
        {
            current = default(T);
            myNode = myList.Head;
            index = 0;
        }
    }
}
