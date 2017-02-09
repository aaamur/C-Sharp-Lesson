/*а)Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий
массив заданной размерности и заполняющий массив числами от начального значения с заданным
шагом.Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse,
меняющий знаки у всех элементов массива, Метод Multi, умножающий каждый элемент массива на
определенное число, свойство MaxCount, возвращающее количество максимальных элементов.В
Main продемонстрировать работу класса.
б)* Добавить конструктор и методы, которые загружают данные из файла*/
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class MyArray
    {
        int[] arr;

        public MyArray (int length, int value, int step)
        {
            arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = value;
                value += step;
            }

        }

        public MyArray (string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] elementsFromFile = File.ReadAllLines(fileName);
                int elementsCount = elementsFromFile.Length;

                arr = new int[elementsCount];

                for (int i = 0; i < elementsCount; i++)
                {
                    arr[i] = int.Parse(elementsFromFile[i]);
                }
            } else
            {
                Console.WriteLine("Error load file");
            }
        }

        public int sum 
        {
            get
            {
                int sum = 0;
                foreach (int element in this.arr)
                {
                    sum += element;
                }

                return sum;
            }
        }

        public int MaxCount
        {
            get
            {
                int count = 0;
                int maxValue = 0;

                foreach (int element in this.arr)
                {
                    if (maxValue < element)
                    {
                        maxValue = element;
                        count = 1;
                    } else if (element == maxValue)
                    {
                        count += 1;
                    }
                }

                return count;
            }
        }


        public void inverseArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
               arr[i] = -arr[i];
            }
                
        }

        public void Multi (int factor)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * factor;
            }

        }

        public void Print ()
        {
            foreach (int element in this.arr)
            {
                Console.Write(element + " ");
            }
        }

    }
}
