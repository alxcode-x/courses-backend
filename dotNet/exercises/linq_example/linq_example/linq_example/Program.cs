using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> persona = new List<Persona>()
            {
                new Persona() { Name = "Alexis", Age = 27 },
                new Persona() { Name = "Barrio", Age = 23 },
                new Persona() { Name = "Pancho", Age = 31 },
                new Persona() { Name = "Pepe", Age = 19 }
            };

            List<Persona> persona2 = new List<Persona>()
            {
                new Persona() { Name = "Francisco", Age = 27 },
                new Persona() { Name = "Yesenia", Age = 28 },
                new Persona() { Name = "Juan", Age = 44 },
                new Persona() { Name = "Chucho", Age = 38 }
            };


            List<string> namesOrdered = (from p in persona
                                         join p2 in persona2
                                         on new {p.Age} equals new { p2.Age }
                                         select p.Name_Age).ToList();
                                        
                                        
                                         

            foreach (var name in namesOrdered)
            {
                Console.WriteLine(name);
            }
        }
    }

    public class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Name_Age
        {
            get { return Name + " - " + Age; }
        }
    }
}


