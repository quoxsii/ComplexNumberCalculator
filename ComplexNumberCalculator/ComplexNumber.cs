using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumberCalculator
{
    class ComplexNumber
    {
        public int a;
        public int b;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public string Output()
        {
            string aStyle = a < 0 ? $"({a})" : $"{a}";
            string bStyle = b < 0 ? $"({b})" : $"{b}";
            return $"({aStyle} + {bStyle}i)";
        }

        public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y)
        {
            ComplexNumber resultCN = new ComplexNumber
            {
                a = x.a + y.a,
                b = x.b + y.b
            };
            return resultCN;
        }

        public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y)
        {
            ComplexNumber resultCN = new ComplexNumber
            {
                a = x.a - y.a,
                b = x.b - y.b
            };
            return resultCN;
        }

        public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
        {
            ComplexNumber resultCN = new ComplexNumber
            {
                a = x.a * y.a - x.b * y.b,
                b = x.b * y.a + x.a * y.b
            };
            return resultCN;
        }
    }
}
