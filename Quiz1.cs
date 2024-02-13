using System;

namespace Activity2
{



    class Person
    {

        public String Name { get; set; }

        public int Weight { get; set; }
    }





    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();



            while (true)
            {
                Console.WriteLine("Enter your new Data Yis/Naw");

                if (Console.ReadLine() == "Naw")
                {
                    break;
                }
                Person person1 = new Person();
                Console.WriteLine("Enter Your Name= ");
                person1.Name = Console.ReadLine();
                Console.WriteLine("Enter your Weight");
                person1.Weight = int.Parse(Console.ReadLine());

                list.Add(person1);




            }
            list.ForEach(x =>
            {
                Console.WriteLine(x.Name);
                Console.WriteLine(x.Weight);
                Console.WriteLine("----------------------");

            });
        }

    }
}
