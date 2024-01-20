using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_14
{
    class Dog : Animal
    {
        string say;
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = "Собака";
            }
        }
        public Dog(string name, string say)
            : base(name)
        {
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }

    }
}

