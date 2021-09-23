using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calc.Model
{
    public class Calc
    {
        public float Add(float paramOne, float paramTwo)
        { return (paramOne + paramTwo); }

        public float Sub(float paramOne, float paramTwo)
        { return (paramOne - paramTwo); }

        public float Mul(float paramOne, float paramTwo)
        { return (paramOne * paramTwo); }

        public float Div(float paramOne, float paramTwo)
        { return (paramOne / paramTwo); }

    }
}
