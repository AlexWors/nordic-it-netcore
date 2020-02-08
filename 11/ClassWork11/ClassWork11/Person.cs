using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork11
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int AgeInFourYears
        {
            get { return Age; }
        }
        public int AgeInFourYearsMethod()
        {
            return Age + 4;
        }

        public string PropertiesString
        {
            get { return $"Name: {Name}, age in 4 years: {AgeInFourYearsMethod()}."; }
        }

    }
}
