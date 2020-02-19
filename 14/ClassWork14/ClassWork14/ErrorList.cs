using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassWork14
{
    class ErrorList : IDisposable, IEnumerable<string>
    {
        public string Category { get; }

        public void WriteToConsole()
        {
            foreach (var error in _errors)
            {


                Console.WriteLine($"Error category {_errors.Category}: {error}");
                
            }
        }

        public string OutputPrefixFormat { get; set; }

        static ErrorList()
        {
            
        }

        private List<string> _errors;

        public void Add(string errorMessage)
        {
            _errors.Add(errorMessage);
        }

        public ErrorList(string category)
        {
            Category = category;
            _errors = new List<string>();
        }

        public void Dispose()
        {
            _errors?.Clear();
            _errors = null;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _errors.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
