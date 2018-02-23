using System;

abstract class Animal {
  public string name;
  public abstract void Cry();
  public void Move() {
    Console.WriteLine("Move()");
  }
}

class Dog : Animal {
  public override void Cry() {
    Console.WriteLine("Bark");
  }
}

class MainClass {
  public static void Main (string[] args) {
    // Animal ani = new Animal();                          // error
    Dog dog = new Dog();
    dog.Cry();
  }
}