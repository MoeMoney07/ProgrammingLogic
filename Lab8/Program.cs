using System;

class Animal  // Step 1: 
{
    public virtual void animalSound()  // Virtual method
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Cat : Animal  // Step 2: 
{
    public override void animalSound()  // Overriding the animalSound() method
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog : Animal  // Step 2: 
{
    public override void animalSound()  // Overriding the animalSound() method
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();  // Step 3: Animal object
        Animal myCat = new Cat();        // Step 3: Cat object
        Animal myDog = new Dog();        // Step 3: Dog object

        myAnimal.animalSound();  // Calls Animal's animalSound
        myCat.animalSound();     // Calls Cat's overridden animalSound
        myDog.animalSound();     // Calls Dog's overridden animalSound
    }
}
