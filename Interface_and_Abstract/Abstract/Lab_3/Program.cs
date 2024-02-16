using System.ComponentModel.DataAnnotations;

namespace Lab_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cat Cat = new Cat();
            Console.WriteLine("Enter cat name: ");
            Cat.SetName(Console.ReadLine());
            Console.WriteLine(Cat.GetName());
            Cat.Eat();

            Dog Dog = new Dog();
            Console.WriteLine("Enter dog name: ");
            Dog.SetName(Console.ReadLine());
            Console.WriteLine(Cat.GetName());
            Dog.Eat();

            Console.ReadKey();
        }
    }
}
