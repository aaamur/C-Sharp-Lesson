/*
 * *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
 * Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
 * Написать программу, демонстрирующую все разработанные элементы класса. 
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Fractions
    {
        int divided;
        int divider;

        public Fractions ()
        {
            this.divided = 0;
            this.divider = 0;
        }

        public Fractions(int divided, int divider)
        {
            this.divided = divided;
            this.divider = divider;

        }

        public int Divided
        {
            get { return this.divided; }
            set { this.divided = value; }
        }
        
        public int NOD (int divider1, int divider2)
        {
            int div;
            if (divider1 == divider2) return divider1;
            int d = divider1 - divider2;
            if (d < 0)
            {
                d = -d;
                div = NOD(divider1, d);
            } else
            {
                div = NOD(divider2, d);
            }

            return div;
        }

        public int NOK(int divider1, int divider2)
        {
            return (divider1 * divider2) / NOD(divider1, divider2);
        }

        public int Divider
        {
            get { return this.divider; }
            set { this.divider = value; }
        }

        public Fractions Plus(Fractions x)
        {
            int div = NOK(this.divider, x.divider);
            Fractions result = new Fractions();
            result.divided = (div / this.divider) * this.divided + (div / x.divider) * x.divided;
            result.divider = div;
            return result;
        }

        public string ToString()
        {
            return this.divided + "/" + this.divider;
        }
    }
}
