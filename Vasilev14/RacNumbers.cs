using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasilev14
{
    internal class RacNumbers
    {
        public int numerator; //числитель
        public int denominator; //знаменатель
        public RacNumbers(int newNum, int newDenom)
        {
            numerator = newNum; 
            denominator = newDenom;
        }
        public static bool operator ==(RacNumbers number1, RacNumbers number2)
        {
            if (number1.denominator == number2.denominator && number1.numerator == number2.numerator) return true;
            else return false;
        }
        public static bool operator !=(RacNumbers number1, RacNumbers number2)
        {
            if (number1.denominator != number2.denominator && number1.numerator != number2.numerator) return true;
            else return false;
        }
        public static bool operator <(RacNumbers number1, RacNumbers number2)
        {
            if ((number1.numerator/number1.denominator) < (number2.numerator/number2.denominator)) return true;
            else return false;
        }
        public static bool operator >(RacNumbers number1, RacNumbers number2)
        {
            if ((number1.numerator / number1.denominator) > (number2.numerator / number2.denominator)) return true;
            else return false;
        }
        public static bool operator <=(RacNumbers number1, RacNumbers number2)
        {
            if ((number1.numerator / number1.denominator) <= (number2.numerator / number2.denominator)) return true;
            else return false;
        }
        public static bool operator >=(RacNumbers number1, RacNumbers number2)
        {
            if ((number1.numerator / number1.denominator) >= (number2.numerator / number2.denominator)) return true;
            else return false;
        }
        public static RacNumbers operator +(RacNumbers number1, RacNumbers number2)
        {
            int nod = NOD(number1.denominator, number2.denominator);
            int num1 = number1.numerator * (nod / number1.denominator);
            int num2 = number2.numerator * (nod / number2.denominator);
            return new RacNumbers(num1 + num2, nod);
        }
        public static RacNumbers operator ++(RacNumbers number1)
        {
            return new RacNumbers(number1.numerator += number1.denominator, number1.denominator);
        }
        public static RacNumbers operator -(RacNumbers number1, RacNumbers number2)
        {
            int nod = NOD(number1.denominator, number2.denominator);
            int num1 = number1.numerator * (nod / number1.denominator);
            int num2 = number2.numerator * (nod / number2.denominator);
            return new RacNumbers(num1 - num2, nod);
        }
        public static RacNumbers operator --(RacNumbers number1)
        {
            return new RacNumbers(number1.numerator -= number1.denominator, number1.denominator);
        }
        private static int NOD(int one, int two)
        {
            while (one != 0 & two != 0)
            {
                if (one > two)
                    one = one % two;
                else
                    two = two % one;
            }
            return one + two;
        }

        public static RacNumbers operator *(RacNumbers number1, RacNumbers number2)
        {
            number1.numerator *= number2.numerator;
            number1.denominator *= number2.denominator;
            return number1;
        }

        public static RacNumbers operator /(RacNumbers number1, RacNumbers number2)
        {
            number1.denominator *= number2.numerator;
            number1.numerator *= number2.denominator;
            return number1;
        }

        public static RacNumbers operator %(RacNumbers number1, RacNumbers number2)
        {
            //Потом
            number1.denominator *= number2.numerator;
            number1.numerator *= number2.denominator;
            return number1;
        }

        public float getFloat()
        {
            return numerator / denominator;
        }

        public override string ToString()
        {
            return $"{numerator}/ {denominator}";
        }
    }
}
