using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Example
{
    internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine(" Dong vat an 1 vai thu");
        }
        public void DoSomeThing()
        {
            Console.WriteLine(" Dong vat lam 1 vai thu");
        }
        
    }
    class Cat : Animal { 
        public void Actions()
        {
            Eat();
            DoSomeThing();
        }
    }
}
