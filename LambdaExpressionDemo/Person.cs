using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressionDemo
{
    class Person
    {
        public string SSN, Name, Address;
        public int Age;

        public Person(string ssn, string name, string address, int age)
        {
            SSN = ssn;
            Name = name;
            Address = address;
            Age = age;
        }
    }
}
