using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack(5);
            myStack.Push("1");
            myStack.Push("2");
            myStack.Push("3");
            Console.WriteLine(myStack.ToString());

            myStack.Pop();
            Console.WriteLine(myStack.ToString());

            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Count);
            Console.WriteLine(myStack.SpaceLeft());

            Console.ReadLine();
        }
    }
}
