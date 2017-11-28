using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDojo
{
    class MyStack
    {
        public int Size { set; get; }
        private string[] Stack;
        public int Count { get; set; }


        public MyStack(int size)
        {
            Stack = new string[size];
            this.Size = size;
            Count = 0;
        }

        public void Push(string newItem)
        {
            if (Count < Size)
            {
                Stack[Count] = newItem;
                Count++;
            } else
            {
                throw new StackOverflowException("Stackoverflow exception");
            }
        }

        public void Pop()
        {
            if (Count > 1)
            {
                Count--;
            } else
            {
                throw new InvalidOperationException("Stackunderflow exception");   
            }
        }

        public string Peek()
        {
            return Stack[Count-1];
        }

        public int SpaceLeft()
        {
            return Size - Count;
        }


        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Count; i++)
            {
                result += Stack[i] + " ";
            }
            return result;
        }
    }
}
