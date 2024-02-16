using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IAnimal
    {
        double Height { get; set; }
        string Name { get; set; }
        string Age { get; set; }
        string Color { get; set; }
        public abstract void Eat();
        string Cry();
    }
}
