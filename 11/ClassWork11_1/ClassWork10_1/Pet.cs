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
                if (value == 'M' || value == 'm' || value == 'F' || value == 'f')
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
            get { return $"{Name} is a {Kind} ({Sex}) of {GetAge()} years old. " + $"birth place {_birthPlace}"; }
        }

        public void SetBirthPlace(string birthPlace)
        {
            _birthPlace = birthPlace;
        }

        public DateTimeOffset BirthDate { get; set; }

        public string ShortDiscription
        {
            get { return $"{Name} is a {Kind}."; }
        }

        public Pet() { }

        public Pet(string name, int age, Kind kind, char sex, DateTimeOffset birthDate)
        {
            Name = name;
            Age = age;
            Sex = sex;
            BirthDate = birthDate;
            Kind = kind;
        }

        public int GetAge()
        {
            var per = DateTime.Now - BirthDate;
            return (int)(per.Days / 365.242);
        }


        public void WriteDescription(bool isFullDiscription)
        {
            if (isFullDiscription)
            {
                Console.WriteLine(Description);
            }
            else
            {
                Console.WriteLine(ShortDiscription);
            }

        }
    }
}
