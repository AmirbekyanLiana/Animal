using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
   abstract class Animal
    {
        public string Name;
        public abstract void GetName();
        public abstract void SetName(string name);
        public abstract void Eat();
        
    }
}
