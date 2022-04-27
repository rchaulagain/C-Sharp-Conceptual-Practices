using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Console_Practice
{
    public class Stack_Practice
    {
        public Stack_Practice()
        {

        }

        public Stack<string> StackObjects()
        {
            var stackObj = new Stack<string>();
            stackObj.Push("1st Item in the stack.");
            stackObj.Push("2nd Item in the stack.");
            stackObj.Push("3rd Item in the stack.");
            stackObj.Push("4th Item in the stack.");
            return stackObj;
        }
        public void PrintStackObjects()
        {
            Console.WriteLine("\t \t \t-------Stack Practice Sample--------");
            Console.WriteLine("\n \t Total Stack Items Count : {0}", StackObjects().Count);
            Console.WriteLine("\t Stacked Items");
            Print(StackObjects());

        }
        public void Print(IEnumerable enumerable)
        {
            foreach (var item in enumerable)
                Console.WriteLine($"\t {item} ");
            Console.WriteLine();

        }
    }
}
