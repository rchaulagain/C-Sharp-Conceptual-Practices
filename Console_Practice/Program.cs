using System;

namespace Console_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            #region How to stack the obects and read
            var stack_Practice = new Stack_Practice();
            stack_Practice.StackObjects(); // first stack the objets
            stack_Practice.PrintStackObjects(); // now we print the stacked objects
            #endregion How to stack the obects and read

        }
    }
}
