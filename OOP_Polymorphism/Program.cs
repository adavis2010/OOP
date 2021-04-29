using System;

namespace OOP_PolyMorphism
{
    class Animal  // Base class (PARENT) 
    {
  public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class (child) 
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says: oink oink");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: woof woof");
    }
}
    class Cow : Animal  //(child class) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The cow says: moo moo");
        }
    }

    class Sheep : Animal  //(child class) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The sheep says: baa baa");
        }
    }
    class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();  // Creating Animal object
        Animal myPig = new Pig(); 
        Animal myDog = new Dog(); 
        Animal myCow = new Cow();
        Animal mySheep = new Sheep();


        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
        myCow.animalSound();
        mySheep.animalSound();
    }
}
    }

