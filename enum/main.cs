using System;

class MainClass {
  enum Animal { MOUSE, CAT, BIRD, DOG=100, LION };
  
  public static void Main (string[] args) {
    Animal a = Animal.DOG;
    Console.WriteLine(a);
    Console.WriteLine((int)a);
    Console.WriteLine((int)Animal.MOUSE);
  }
}