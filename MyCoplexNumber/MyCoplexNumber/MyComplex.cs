using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoplexNumber
{
   public class MyComplex
    {
        public double real { get; set; }
        public double imaginary { get; set; }

        public MyComplex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public double Abs() => Math.Sqrt((real*real) + (imaginary*imaginary));

        public static MyComplex operator +(MyComplex a, MyComplex b)
        {

            return new MyComplex((a.real + b.real), (a.imaginary + b.imaginary));

        }

        public static MyComplex operator -(MyComplex a, MyComplex b)
        {

            return new MyComplex((a.real - b.real), (a.imaginary - b.imaginary));

        }

        public override string ToString()
        {
            return $"({real.ToString()},  {imaginary.ToString()})";
        }
    }
}
