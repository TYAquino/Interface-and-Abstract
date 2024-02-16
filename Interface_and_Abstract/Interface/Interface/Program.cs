namespace Interface
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cat Cat = new Cat();
            Console.WriteLine("Enter cat name: ");
            Cat.Name = Console.ReadLine();
            Console.WriteLine("Name: " + Cat.Name);
            Cat.Eat();
            Console.WriteLine("The cat says: " + Cat.Cry());

            Console.WriteLine();

            Dog Dog = new Dog();
            Console.WriteLine("Enter dog name: ");
            Dog.Name = Console.ReadLine();
            Console.WriteLine("Name: " + Dog.Name);
            Dog.Eat();
            Console.WriteLine("The dog says: " + Dog.Cry());

            Console.WriteLine();

            var animals = new List<IAnimal>();

            animals.Add(new Dog { Name = "Robin" });
            animals.Add(new Dog { Name = "Becky" });
            animals.Add(new Cat { Name = "Kitty" });
            animals.Add(new Cat { Name = "Sammy" });

            Console.WriteLine("These are the names of the pets that we have:");
            PrintAnimals(animals);

            Console.ReadKey();
        }

        private static void PrintAnimals(IEnumerable<IAnimal> animals)
        {
            foreach (IAnimal animal in animals) 
            {
                Console.WriteLine("This is {0} : {1}", animal.Name, animal.Cry());
            }
        }
    }
}
