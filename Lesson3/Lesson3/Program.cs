using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Complex b,a,c;
            b.im = 1;
            b.re = 3;
            a.im = 2;
            a.re = 6;

            c = b.Minus(a);
            Console.WriteLine(c.ToString());

            ClassComplex aComplex = new ClassComplex(1,3);
            ClassComplex bComplex = new ClassComplex(2,6);
            ClassComplex cComplex = new ClassComplex();
            ClassComplex dComplex = new ClassComplex();
            cComplex = aComplex.Minus(bComplex);

            Console.WriteLine(cComplex.ToString());
            /*
            Console.WriteLine("task2");
            task2 task2 = new task2();
            int sum = task2.getSumOfPositiveNumber();
            Console.WriteLine(sum);*/

            Console.WriteLine("task3");
            Fractions d1 = new Fractions(3,8);
            Fractions d2 = new Fractions(5,12);
            Fractions result = new Fractions();

            result = d1.Plus(d2);

            Console.WriteLine(result.ToString());


            Console.ReadLine();
        }
    }
}
