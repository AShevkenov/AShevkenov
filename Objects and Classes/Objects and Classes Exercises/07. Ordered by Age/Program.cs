using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Ordered_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            List<People> people = new List<People>();

            while (data != "End")
            {
                string[] information = data.Split();
                string name = information[0];
                string id = information[1];
                int age = int.Parse(information[2]);

                People person = new People()
                {
                    Name = name,
                    ID = id,
                    Age = age

                };

                data = Console.ReadLine();

                people.Add(person);
            }

            foreach (var person in people.OrderBy(person => person.Age))
            {
                Console.WriteLine(person);
            }
        }
    }


    class People
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"{Name} with ID: {ID} is {Age} years old.";
   
    }
}
