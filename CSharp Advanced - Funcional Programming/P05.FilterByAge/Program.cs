using System.Runtime.CompilerServices;

namespace P05.FilterByAge
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                people.Add(new Person(input[0], int.Parse(input[1])));
            }

            string conditionInput = Console.ReadLine();
            int thresholdInput = int.Parse(Console.ReadLine());
            string formatInput = Console.ReadLine();

            Func<Person, int, bool> condition = Filter(conditionInput);
            people = people.Where(x => condition(x, thresholdInput)).ToList();

            Action<Person> print = Print(formatInput);
            people.ForEach(print);


            static Func<Person, int, bool> Filter(string conditionInput)
            {
                return conditionInput switch
                {
                    "younger" => (person, age) => person.Age < age,
                    "older" => (person, age) => person.Age >= age,
                    _ => null

                };
            }

            static Action<Person> Print(string formatInput)
            {
                return formatInput switch
                {
                    "name" => x => Console.WriteLine(x.Name),
                    "age" => x => Console.WriteLine(x.Age),
                    "name age" => x => Console.WriteLine($"{x.Name} - {x.Age}"),
                    _ => null
                };
            }
        }
    }
    
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}



