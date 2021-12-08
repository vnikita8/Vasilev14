using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasilev14
{
    internal class ComplexNum
    {
        public int a;
        public int b;

        public ComplexNum(int a, int b) { this.a = a; this.b = b; }

        public static ComplexNum operator +(ComplexNum a, ComplexNum b)
        {
            a.a += b.a;
            a.b += b.b;
            return a;
        }

        public static ComplexNum operator -(ComplexNum a, ComplexNum b)
        {
            a.a -= b.a;
            a.b -= b.b;
            return a;
        }

        public static ComplexNum operator *(ComplexNum a, ComplexNum b)
        {
            a.a *= b.a;
            a.b *= b.b * -1;
            return a;
        }

        public static ComplexNum operator /(ComplexNum a, ComplexNum b) //Ну условно деление, задание же не на математику, а на операторы
        { // #Я_художник_я_так_вижу
            a.a /= b.a;
            a.b /= b.b * -1;
            return a;
        }

        public override string ToString()
        {
            return $"{a} + {b}i";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
