using System;

class MainClass {
    public static int Plus(int a, int b) {
      return a + b;
    }
    
  public static void Main (string[] args) {
    Console.WriteLine(Plus(10,10));
    Console.WriteLine(Plus(100,100));
  }
}