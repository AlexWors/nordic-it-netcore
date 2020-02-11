using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork10
{
    class person
    {
        private string _name;
        private int _age;
        
        public string Name
        {
            get { return _name; }
            set
            {
                if(value == string.Empty)
                {
                    throw new Exception("Введена пустая строка!");
                }
                _name = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Вораст не может быть отрицательным!");
                }
                _age = value;
            }
        }

        public int AgeAfterFourYears
        {
            get { return Age + 4; }
        }

        public string Output
        {
            get
            {
                return $"Имя: {Name}. Возраст через 4 года: {AgeAfterFourYears}";
            }
        }
    }
}
