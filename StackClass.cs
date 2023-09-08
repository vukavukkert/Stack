using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class StackClass : ICloneable
    {
        List<int> newList;
        public int MaxSize;
        private int Count = 0;
        public object Clone() => MemberwiseClone();
        public StackClass(int maxSize)
        {
            newList = new List<int>(maxSize);
            MaxSize = maxSize;
        }
        public StackClass(StackClass obj)
        {
           MaxSize = obj.MaxSize;
           newList = obj.newList;
            Count = obj.Count;
        }
        public void Push(int value)
        {
            if(Count < MaxSize)
            {
                newList.Add(value);
                Count++;
            }
            else
            {
                throw new InvalidOperationException("Stack is full");
            }
        }
        public int Pop() 
        {
            int a = newList[Count-1];
            newList.RemoveAt(Count -1);
            Count--;
            return a;
        }
        public int Peek()
        {
            return newList[Count - 1];
        }
    }
}
