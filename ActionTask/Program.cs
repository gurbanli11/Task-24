using ActionTask.Models;

namespace ActionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
        {
            new Person { Name = "Kamil", Surname = "Aliyev", Age = 25 },
            new Person { Name = "Kerem", Surname = "Qehramanov", Age = 30 },
            new Person { Name = "Fuad", Surname = "Dashdemirov", Age = 20 },
            new Person { Name = "Rauf", Surname = "Dostuyev", Age = 18 },
            new Person { Name = "Ehmed", Surname = "Huseynov", Age = 28 },
            new Person { Name = "Kamil", Surname = "Musayev", Age = 28 }
        };
            //var kamil = people.FindAll(p => p.Name == "Kamil");
            //Console.WriteLine("Adı Kamil olanlar:");
            //foreach (var person in kamil)
            //{
            //    Console.WriteLine($"{person.Name} {person.Surname}, Yaş: {person.Age}");
            //}
            //var surname = people.FindAll(p => p.Surname = ("ov") || p.Surname = ("ova"));
            //Console.WriteLine("\nSoyadı ov və ova ilə bitən tələbələr:");
            //foreach (var person in surname)
            //{
            //    Console.WriteLine($"{person.Name} {person.Surname}, Yaş: {person.Age}");
            //}
            var twenty = people.FindAll(p => p.Age > 20);
            Console.WriteLine("\n20 yaşından böyük olanlar:");
            foreach (var person in twenty)
            {
                Console.WriteLine($"{person.Name} {person.Surname}, Yaş: {person.Age}");
            }
        }

    }
}