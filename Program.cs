using System;

namespace Method_oevr_riding
{
    public class animal
    {
        public virtual void eat()
        {
            Console.WriteLine(" animal is eating");
        }

    }
    public class Dog : animal
    {
        public override void eat()
        {
            Console.WriteLine(" animal is eating bread");
        }

        public class testoverriding
        {


            public static void Main(string[] args)
            {
                Dog D = new Dog();
                D.eat();
            }
        }
    }
}
