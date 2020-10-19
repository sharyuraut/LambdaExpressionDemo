using System;
using System.Collections.Generic;
using System.Linq;

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
            Retrieve_top2_ForAgeLessThan60(listPersonInCity);
            Console.WriteLine("------------");
            Retrieve_DataAgeBetween13And18(listPersonInCity);
            Console.WriteLine("------------");
            GiveAverageAge(listPersonInCity);
            Console.WriteLine("------------");
            CheckSpecificNamePresent(listPersonInCity);
            Console.WriteLine("------------");
            SkipRecord_IfAgeIsLessThan60(listPersonInCity);
        }

        //UC1
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("aaa", "bbb", "abc", 19));
            listPersonInCity.Add(new Person("asd", "qwer", "qwsx", 15));
            listPersonInCity.Add(new Person("qqw", "asdf", "sedr", 61));
            listPersonInCity.Add(new Person("qre", "zxxv", "wse", 32));
            listPersonInCity.Add(new Person("wdx", "wsdf", "aws", 10));
            listPersonInCity.Add(new Person("zse", "asde", "wed", 50));
            listPersonInCity.Add(new Person("zse", "asde", "wed", 50));
            listPersonInCity.Add(new Person("zbse", "asdhe", "weud", 80));
            listPersonInCity.Add(new Person("zske", "asden", "whyed", 70));
        }

        //UC 2
        private static void Retrieve_top2_ForAgeLessThan60(List<Person> listPersonInCity)
        {
            foreach(Person person in listPersonInCity.FindAll(e => e.Age <= 60).Take(2).ToList())
            {
                Console.WriteLine("Name: " + person.Name + "\t" + "Age: " + person.Age);
            }
        }

        //UC3
        private static void Retrieve_DataAgeBetween13And18(List<Person> listPersonInCity)
        {
            if(listPersonInCity.Any(e => (e.Age >=13 && e.Age <= 18)))
            {
                Console.WriteLine("Teenage Present");
            }
            else
            {
                Console.WriteLine("No teenage present");
            }
        }

        //UC4
        private static void GiveAverageAge(List<Person> listPersonInCity)
        {
            double Average = listPersonInCity.Average(e => e.Age);
            Console.WriteLine("Average: " + Average); 
        }

        //UC5
        private static void CheckSpecificNamePresent(List<Person> listPersonInCity)
        {
            Console.WriteLine("Enter a name to search: ");
            string name = Console.ReadLine();
            if(listPersonInCity.Any(e => (e.Name.Equals(name))))
            {
                Console.WriteLine("Person Present");
            }
            else
            {
                Console.WriteLine("Person not present");
            }
        }

        //UC6
        private static void SkipRecord_IfAgeIsLessThan60(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.OrderBy(e => e.Age).SkipWhile(e => e.Age < 60))
            {
                Console.WriteLine("Name :" + person.Name + " Age :" + person.Age);
            }
        }
    }
}