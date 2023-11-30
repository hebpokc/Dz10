using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab12
{
    class ComplexNumber
    {
        double realPart;
        double imaginaryPart;
        public ComplexNumber(double r, double i)
        {
            realPart = r;
            imaginaryPart = i;
        }
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.realPart + b.realPart, a.imaginaryPart + b.imaginaryPart);
        }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.realPart - b.realPart, a.imaginaryPart - b.imaginaryPart);
        }
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.realPart * b.realPart - a.imaginaryPart * b.imaginaryPart, a.realPart * b.imaginaryPart + a.imaginaryPart * b.realPart);
        }
        public override bool Equals(object obj)
        {
            return this.realPart == (obj as ComplexNumber).realPart && this.imaginaryPart == (obj as ComplexNumber).imaginaryPart;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(ComplexNumber a, ComplexNumber b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            if (imaginaryPart > 0) 
                return $"{realPart}+{imaginaryPart}i";
            else
                return $"{realPart}{imaginaryPart}i";
        }
    }
}
