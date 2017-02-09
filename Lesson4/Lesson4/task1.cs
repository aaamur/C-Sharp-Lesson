/*Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
значения от –10 000 до 10 000 включительно.Написать программу, позволяющую найти и вывести
количество пар элементов массива, в которых хотя бы одно число делится на 3. В данной задаче
под парой подразумевается два подряд идущих элемента массива.Например, для массива из пяти
элементов: 6; 2; 9; –3; 6 – ответ: 4.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class task1
    {
        int[] arr = { 1, 2, 3, 9, 1, 4, 6, 4, 2, 3};

        public int run()
        {
            int count = 0;
            bool isCurrentDivideWithoutModulo = false;
            bool isNextDivideWithoutModulo = false;

            int arrayLength  = arr.Length;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                isCurrentDivideWithoutModulo = isDivideWithoutModulo(arr[i], 3);
                isNextDivideWithoutModulo = isDivideWithoutModulo(arr[i + 1], 3);

                if (isCurrentDivideWithoutModulo || isNextDivideWithoutModulo)
                {
                    count++;
                }
            }

            return count;
        }

        public bool isDivideWithoutModulo(int number, int divider)
        {
            if (number % divider == 0)
            {
                return true;
            } 
            return false;
        }

    }
}
