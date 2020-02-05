using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork10_1
{
    public enum Kind
    {
        Mouse,
        Cat,
        Dog
    }
    class Pet
    {
        private string _birthPlace;
        private char _sex;
        public string Name;


        public Kind Kind;
        public int Age { get; set; }
        public char Sex 
        { 
            get 
            { return _sex; } 
            set 
            { 
                if(value == 'M' || value == 'm' || value == 'F' || value == 'f')
                {
                    _sex = value;
                }
                else
                {
                    throw new Exception("Ошибка! Какой то подозрительный пол!");
                }
            } 
        }

        public string Description
        {
            get { return $"{Name} is a {Kind} ({Sex}) of {Age} years old." + $"birth place {_birthPlace}"; }
        }

        public void SetBirthPlace(string birthPlace)
        {
            _birthPlace = birthPlace;
        }



    }
}
