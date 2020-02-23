using System;


namespace GitTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass(2, 4);

            Console.WriteLine(testClass.number1);
            Console.WriteLine(testClass.number2);

            Person person1 = new Person(18, 300);

            Person person2 = new Person(20, 500);

            Console.WriteLine(person1.location);
            Console.WriteLine(person2.location);

            
        }
    }
}
