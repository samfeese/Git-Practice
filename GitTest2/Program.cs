using System;
using TestNamespace;

namespace GitTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass(2, 4);

            Console.WriteLine(testClass.number1);
            Console.WriteLine(testClass.number2);

            
        }
    }
}
