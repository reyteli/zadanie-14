using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_14
{
    class Cat : Animal
    {
        private string say;
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = "Кошка";
            }
        }
         public Cat(string name, string say)
            : base(name)
        {
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }


    }
}
