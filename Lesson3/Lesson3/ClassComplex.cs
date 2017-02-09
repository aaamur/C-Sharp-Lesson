/*
 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверит работу класса;
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class ClassComplex
    {

            private double im;
            double re;

            public ClassComplex()
            {
                im = 0;
                re = 0;
            }
           
            public ClassComplex(double im, double re)
            {
                this.im = im;
                this.re = re;
            }
            public ClassComplex Plus(ClassComplex x2)
            {
                ClassComplex x3 = new ClassComplex();
                x3.im = x2.im + im;
                x3.re = x2.im + re;
                return x3;
            }

            public ClassComplex Minus(ClassComplex x)
            {
                ClassComplex y = new ClassComplex();
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            public ClassComplex Multi(ClassComplex x)
            {
                ClassComplex y = new ClassComplex();
                y.im = im * x.im + re * x.im;
                y.re = re * x.im - im * x.re;
                return y;
            }

        public double Im
            {
                get { return im; }
                set
                {
                    if (value >= 0) im = value;
                }
            }

            public string ToString()
            {
                return re + "+" + im + "i";
            }


    }
}
