using System;

namespace Inheritance2
{
    //base class
    class Animal
    {
        protected void eat()
        {
            Console.WriteLine("I can eat");
        }
    }

    // derived class of Animal
    class Dog : Animal
    {
        static void Main(string[] args)
        {
            Dog labrador = new Dog();

            //accessing protected method from base class
            labrador.eat();

            Console.ReadLine();
        }
    }
}
