using System;

namespace Animal
{
    
    class Program
    {        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Dog dog = new Dog();
            dog.GetName();
            dog.Eat();
        }
    }
}
