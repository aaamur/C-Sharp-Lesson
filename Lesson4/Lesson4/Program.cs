using System;
using System.Linq;
using System.Text;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            task1 task1 = new task1();
            Console.WriteLine(task1.run());

            Console.WriteLine("Task2");
            MyArray array = new MyArray(@"c:\temp\data.txt");
            array.Print();

            Console.WriteLine("Sum");
            Console.WriteLine(array.sum);

            Console.WriteLine("MaxCount");
            Console.WriteLine(array.MaxCount);

            Console.WriteLine("Multi");
            array.Multi(2);
            array.Print();

            Console.WriteLine("Inverse");
            array.inverseArray();
            array.Print();

            Console.ReadLine();
        }
    }
}
