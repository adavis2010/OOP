using System;

namespace OOP_Polymorphism
{
    class Program
    {


        class Animal  // Base class (parent) 
        {
            public void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
                Console.WriteLine("The pig says: wee wee");
                Console.WriteLine("The dog says: bow wow");
                Console.WriteLine("The cow says: moo moo");
            }
        }

        class Pig : Animal  // (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");

            }
        }

        class Dog : Animal  //  (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }

        class Cow : Animal  //  (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The Cow says: moo moo");
            }
        }


        static void Main(string[] args)
            {
                Animal myAnimal = new Animal();  // Create Animal object
                Animal myPig = new Pig();  // Creating Pig 
                Animal myDog = new Dog();  // Creating Dog 
                Animal myCow = new Cow(); // Creating Cow

                myAnimal.animalSound();
                myPig.animalSound();
                myDog.animalSound();
            }
        }
    }
  

