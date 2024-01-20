using System;

namespace zadanie_14
{
   class Program
    {
        static void Main(string[] args)
        {
            
            Dog dog = new Dog("Собака", "Гав");
            dog.ShowInfo();
            Cat cat = new Cat("Кошка", "Мяу");
            cat.ShowInfo();
            Console.ReadKey();
        }
    }
}
