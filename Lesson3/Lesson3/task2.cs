/*
 *  С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
 *  Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран; 
 *  Используя tryParse;
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class task2
    {
        public int getSumOfPositiveNumber()
        {
            int res;
            int num = -1;
            bool successParse;
            string str;
            bool Odd;
            int sum = 0;

            do
            {
                str = Console.ReadLine();
                successParse = int.TryParse(str, out res);
                if (successParse)
                {
                    num = int.Parse(str);
                    Odd = num % 2 != 0;

                    if (Odd && num >= 0 )
                    {
                        sum += num;
                    }
                }
            }
            while (num != 0);

            return sum;
        }
    }
}
