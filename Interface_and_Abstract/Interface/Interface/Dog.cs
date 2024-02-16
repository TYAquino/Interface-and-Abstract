using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Color { get; set; }
        public double Height { get; set; }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
        public string Cry()
        {
            return "Woof~!";
        }
    }
}
