using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public abstract class Animal
    {
        private string Name;
        private string Color;
        private int Age;

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetColor(string color)
        {
            Color = color;
        }
        public string GetColor()
        {
            return Color;
        }
        public void SetAge(int age)
        {
            Age = age;
        }
        public int GetAge()
        {
            return Age;
        }
        public abstract void Eat();
    }
}
