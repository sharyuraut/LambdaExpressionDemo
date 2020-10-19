using System;
using System.Collections.Generic;

namespace LambdaExpressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expressions");
            //UC 1
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);
        }

        //UC1
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("aaa", "bbb", "abc", 19));
            listPersonInCity.Add(new Person("asd", "qwer", "qwsx", 25));
            listPersonInCity.Add(new Person("qqw", "asdf", "sedr", 61));
            listPersonInCity.Add(new Person("qre", "zxxv", "wse", 32));
            listPersonInCity.Add(new Person("wdx", "wsdf", "aws", 10));
            listPersonInCity.Add(new Person("zse", "asde", "wed", 50));
        }
    }
}
