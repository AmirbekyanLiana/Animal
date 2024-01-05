using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Dog : Animal
    {
        public override void GetName()
        {
            Console.WriteLine("Enter name of dog");
            SetName(Console.ReadLine());
        }
        public override void SetName(string name)
        {
            Name = name;
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} food is meat and bone");
        }
    }
}
