using System;

namespace PublishEx
{
    class Program
    {
        static void Main(string[] args)
        {
            AddClass addObj = new AddClass();
            Console.WriteLine(addObj.Addition(5, 3));
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
