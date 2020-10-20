using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingOefening



{
    internal class CustomCatError : ApplicationException
    {
        public CustomCatError()
        {

        }
        public CustomCatError(string message): base(message)
        {

        }

        public CustomCatError(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
    class Cat
    {
        public int Age { get; set; }

        public Cat(int age)
        {
            Age = age;
        }
    }
}
