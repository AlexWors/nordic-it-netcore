using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork15
{
    public interface INumber<T>
    {
        T Value { get; set; }
    }
}
