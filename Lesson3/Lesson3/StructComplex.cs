/*
 * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
 *   Продемонстрировать работу структуры; 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    struct Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        Complex Multi(Complex x)
        {
            Complex y;
            y.im = im * x.im + re * x.im;
            y.re = re * x.im - im * x.re;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}
