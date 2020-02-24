using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork15
{
    public class Calculator<T>
    {
        public T Sum(T a, T b)
        {
            return (T)((dynamic)a + (dynamic)b);
        }

        public T Multiply(T a, T b)
        {
            return (T)((dynamic)a * (dynamic)b);
        }

        public T Substract(T a, T b)
        {
            return (T)((dynamic)a - (dynamic)b);
        }

        public T Divide(T a, T b)
        {
            return (T)((dynamic)a / (dynamic)b);
        }
    }
}
