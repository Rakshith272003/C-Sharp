using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("Animal makes Sound");
        }
        public static void run()
        {
            Animal a = new Dog();
            a.sound();
        }
    }
    public class Dog : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    
    
}
